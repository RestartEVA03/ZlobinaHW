#include <iostream>
#include <fstream>
#include <cmath>
using namespace std;

const int Size = 102;
const double Pi = 3.1415926;

ofstream R_out;
ofstream P_out;
ofstream H_out;


void FileOpen(double r[], double decl[], double angle[]) {
    double angle_r[3][Size];
    double decl_r[3][Size];
    ifstream data("data.txt");
        for (int i = 0; i < 101; i++) {
            data >> angle_r[0][i] >> angle_r[1][i] >> angle_r[2][i] >> decl_r[0][i] >> decl_r[1][i] >> decl_r[2][i] >> r[i];
            angle[i] = (angle_r[0][i] + angle_r[1][i] / 60 + angle_r[2][i] / 360) * 2 * Pi / 24;
            decl[i] = (decl_r[0][i] + decl_r[1][i] / 100 * (decl_r[0][i]/abs(decl_r[0][i])) + decl_r[2][i] / 10000 * (decl_r[0][i] / abs(decl_r[0][i]))) * Pi / 180;
        }
        data.close();
    }

double delta(double max, double min, double avr, int size){
	return (max-min)/(avr/(size*size));
}

void r_func(double (&distance_matrix)[Size][Size], double x[], double y[], double z[], double &distance_summ, double &distance_max, double &distance_min){
	    for (int i = 0; i < 100; i++) {//строка
        for (int j = 0; j < 100; j++) {//столбец
            distance_matrix[i][j] = sqrt((x[i] - x[j]) * (x[i] - x[j]) + (y[i] - y[j]) * (y[i] - y[j]) + (z[i] - z[j]) * (z[i] - z[j]));
            distance_summ += distance_matrix[i][j];
            if (distance_matrix[i][j] != 0) {
                if (distance_max == 0) distance_max = distance_min = distance_matrix[i][j];
                if (distance_matrix[i][j] > distance_max) distance_max = distance_matrix[i][j];
                if (distance_matrix[i][j] < distance_min) distance_min = distance_matrix[i][j];
            }
            R_out << distance_matrix[i][j] << " ";
        }
        R_out << endl;
    }
}

void p_func(double (&P_matrix)[Size][Size], double distance_matrix[Size][Size], double distance_summ, double &Psum, double &Pmax, double &Pmin){
    for (int i = 0; i < 100; i++) {//строка
        for (int j = 0; j < 100; j++) {//столбец
            P_matrix[i][j] = distance_matrix[i][j] / distance_summ;
            Psum += P_matrix[i][j];
            if (P_matrix[i][j] != 0) {
                if (Pmax == 0) Pmax = Pmin = P_matrix[i][j];
                if (P_matrix[i][j] > Pmax) Pmax = P_matrix[i][j];
                if (P_matrix[i][j] < Pmin) Pmin = P_matrix[i][j];
            }
            P_out << P_matrix[i][j] << " ";
        }
        P_out << endl;
    }
}

void h_func(double (&H_matrix)[Size][Size], double P_matrix[Size][Size], double &Hsum, double &Hmax, double &Hmin){
    for (int i = 0; i < 100; i++) {//строка
        for (int j = 0; j < 100; j++) {//столбец
            H_matrix[i][j] = P_matrix[i][j] * (1 - P_matrix[i][j]);
            Hsum += H_matrix[i][j];
            if (H_matrix[i][j] != 0) {
                if (Hmax == 0) Hmax = Hmin = H_matrix[i][j];
                if (H_matrix[i][j] > Hmax) Hmax = H_matrix[i][j];
                if (H_matrix[i][j] < Hmin) Hmin = H_matrix[i][j];
            }
            H_out << H_matrix[i][j] << " ";
        }
        H_out << endl;
    }
}


int main()
{
    R_out.open("data_R.txt");
    P_out.open("data_P.txt");
    H_out.open("data_H.txt");
    
    double angle[Size];//угол
    double decl[Size];//склонение в астрономии
    double distance[Size];// расстояние
    double distance_matrix[Size][Size];// матрица расстояний
    double distance_summ = 0; // сумарное расстояние
    double distance_max = 0; // максимально расстояние
	double distance_min = 0; // минимальное расстояние
	double Pmax = 0; // максимальная вероятность
	double Pmin = 0; // минимальная вероятность
	double P_matrix[Size][Size]; // матрица вероятностей
	double Hmax = 0; // максимальная энтропия
	double Hmin = 0; // минимальная энтропия
	double H_matrix[Size][Size]; // матрица энтропий
	double Hsum = 0; // суммарная энтропия
	double Psum = 0; // суммарная вероятность

    FileOpen(distance, decl, angle);
    
    double x[Size], y[Size], z[Size];
    for (int i = 0; i < 100; i++) {//строка
        x[i] = distance[i] * sin(decl[i]) * cos(angle[i]);
        y[i] = distance[i] * sin(decl[i]) * sin(angle[i]);
        z[i] = distance[i] * cos(decl[i]);
    }

	//вычисление dR,dP,dH,H_sum
	r_func(distance_matrix,x,y,z,distance_summ,distance_max,distance_min);
    p_func(P_matrix,distance_matrix,distance_summ,Psum,Pmax,Pmin);
    h_func(H_matrix,P_matrix,Hsum,Hmax,Hmin);
    cout << endl << "dR: " << delta(distance_max,distance_min,distance_summ,Size)
				<< "\ndP: " << delta(Pmax,Pmin,Psum,Size) << "\ndH: " << delta(Hmax,Hmin,Hsum,Size) << "\n\nH_sum: " << Hsum << endl;

    R_out.close();
	P_out.close();
	H_out.close();
	
    return 0;
}
