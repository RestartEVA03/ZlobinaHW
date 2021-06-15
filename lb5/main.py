import math
import random

import matplotlib.pyplot as plt

"""
Построение графика
"""


def plotting(arr):
    plt.title("График распределения случайных чисел.")
    plt.xlabel("Номер числа")
    plt.ylabel("Число")
    new_arr = [float(x) for x in arr]
    plt.scatter(range(len(arr)), new_arr)
    plt.show()

def plotting2(arr1,arr2):
    plt.title("График распределения случайных чисел.")
    plt.xlabel("Номер числа")
    plt.ylabel("Число")
    new_arr = [float(x) for x in arr1]
    plt.scatter(range(len(arr1)), new_arr)
    new_arr2 = [float(x) for x in arr2]
    plt.scatter(range(len(arr2)), new_arr2)
    plt.show()


"""
Метод срединных квадратов
"""


def mean_squares_method(s):
    point = int(input("Введите число с четной разрядностью: 0."))
    result = []
    for i in range(int(s)):
        point = int(point) ** 2
        print(point)
        list_point = list(str(point))
        mid_ind = len(list_point) // 2
        print(mid_ind)
        point = "".join(list_point[mid_ind - 2:mid_ind + 2])
        result.append("0." + point)
        print(result)
    plotting(result)
    return result


"""
Метод срединных произведений
"""


def method_of_median_products(s):
    point1 = int(input("Введите два числа с четной разрядностью\n-0."))
    point2 = int(input("-0."))
    result = []
    for i in range(int(s)):
        point3 = point1 * point2
        list_point = list(str(point3))
        mid_ind = len(list_point) // 2
        result.append("0." + "".join(list_point[mid_ind - 2:mid_ind + 2]))
        point1 = point2
        point2 = point3
        print(result)
    plotting(result)
    return result


"""
Метод перемешивания
"""


def stirring_method(s):
    result = []
    point = input("Введите число с четной разрядностью: 0.")
    for i in range(int(s)):
        print("Point 1:{0} = {1}".format(i, point))
        list_point = list(str(point))
        quarter_ind = len(list_point) // 4
        point2 = str(point)[quarter_ind + 1:] + str(point)[:quarter_ind + 1]
        print("Point 2:{0} = {1}".format(i, point2))
        point3 = str(point)[len(list_point) - quarter_ind - 1:] + str(point)[:len(list_point) - quarter_ind - 1]
        print("Point 3:{0} = {1}".format(i, point3))
        point = int(point2) + int(point3)
        str(point2)
        str(point3)
        tmp = "0." + str(point)
        result.append("%.4f" % float(tmp))
        print(result)
    plotting(result)
    return result


"""
Линейный конгруэнтный метод
"""


def linear_congruent_method(s):
    a = int(input("Введите числа:\na: "))
    b = int(input("b: "))
    m = int(input("M: "))
    r = []
    r.append(int(input("R: ")))
    for i in range(1, int(s)):
        print(i)
        r .append(math.fmod(a * r[i - 1] + b, m))
    print(str(r))
    plotting(r)
    return r

"""
Сравнение с random()
"""

def f_random(size):
    method = int(input("Выберите способ с которым будет сравниваться:\n 1.Метод срединных квадратов\n 2.Метод срединных произведений"
                       "\n 3.Метод перемешивания\n 4.Линейный конгруэнтный метод\n-"))
    r1 =[]
    r2 =[]
    if method == 1:
        r1 = mean_squares_method(size)
    if method == 2:
        r1 = method_of_median_products(size)
    if method == 3:
        r1 = stirring_method(size)
    if method == 4:
        r1 = linear_congruent_method(size)
    for i in range(25):
        r2.append(random.random())
    plotting2(r1,r2)



flag = True
while flag:
    size = 0
    method = int(input("Выберите способ ГСЧ:\n 1.Метод срединных квадратов\n 2.Метод срединных произведений"+
                       "\n 3.Метод перемешивания\n 4.Линейный конгруэнтный метод\n 5.Random()\n 0.Выход\n -"))
    size = input("Введите кол-во точек: ")
    if method == 1:
       mean_squares_method(size)
    if method == 2:
        method_of_median_products(size)
    if method == 3:
        stirring_method(size)
    if method == 4:
        linear_congruent_method(size)
    if method == 5:
        f_random(size)
    if method == 0:
       flag = False
