# kontrolnaya_rabota

# __Описание решения Task_1__

На старте имеется строковый массив данных. Далее объявляется возвращаемая функция, которая имеет строковый тип данных и называется _Create_new_array_ (Далее – Функция), в которую передается имеющийся массива. Внутри Функции объявляется новый массив (_arr_), в который будут передаваться значения удовлетворяющие условия задачи, а именно передаваться элементы, длина которого меньше, либо равна 3 символам. Далее объявляется новая переменная _count_, которая имеет целочисленный тип данных и равна 0. Данная переменная будет считать количество строк, которые удовлетворяют условию задачи. После чего вызывается функция _for_ в которой количество шагов (повторов) должно быть меньше длины первоначального массива таким способом будет перебираться каждый элемент массива. Внутри цикла c помощью условного оператора _if_ будет проверяться каждый элемент массива на предмет выполнения заданного условия (длина элемента первоначального массива должна быть меньше или равна 3), если данное условие верно, тогда новому массиву с индексом _count_ будет присвоено значение элемента _i_ из заданного (первоначального массива), которое меньше либо равно 3, после чего значение переменной _count_ будет увеличиваться на 1. Также за пределами цикла необходимо вернуть новый массив с помощью _return arr_, для того чтобы с ним работать далее.

Второй шаг — это объявить функцию, которая будет выводить массив с элементами, удовлетворяющими условию на «печать». Данная функция будет иметь тип void и принимать значение, полученное из предыдущей функции. Внутри функции объявляется новый массив и с помощью цикла for каждый элемент выводится на печать (Console.Write($"{arr[i]} ");).

string[] array = { ……….} – задается массив данных.
string[] result = Create_new_array(array); - вызывается функция, которая будет создавать новый массив с элементами удовлетворяющими условию задачи.
Print(result); - выводит новый массив («ответ»).
