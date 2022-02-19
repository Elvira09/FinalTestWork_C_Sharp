# Итоговая проверочная работа.

Данная работа необходима для проверки ваших знаний и навыков по итогу прохождения первого блока обучения на программе разработчик. Мы должны убедиться что базовое знакомство с it прошло успешно.

Задача алгоритмически не самая сложная, однако для полценного выполнения проверочной работы необходимо:
1. Создать репозиторий на GitHub
2. Нарисовать блок-схему алгоритма (можно обойтись блок-схемой основной содержательной части, если вы выделяете ее в отдельный метод)
3. Снабдить репозиторий оформленным текстовым описанием решения (файл README.md)
4. Написать программу, решающую поставленную задачу
5. Использовать контроль версий в работе над этим небольшим проектом (не должно быть так что все залито одним коммитом, как минимум этапы 2, 3 и 4 должны быть расположены в разных коммитах)

**Задача**: 

Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

**Примеры**:

["hello", "2", "world", ":-)"] -> ["2", ":-)"]

["1234", "1567", "-2", "computer science"] -> ["-2"]

["Russia", "Denmark", "Kazan"] -> []

---

# РЕШЕНИЕ:
1. Создаем метод **PrintArray** вывода одномерного массива на консоль согласно заданного примера вывода данных
	+ тип метода задаем **void**
	+ в качестве аргумента подаем массив
	+ выводим массив на консоль с помощью цикла **for**

2. Создаем метод **SearchItems** по поиску количества элементов массива длина которых меньше либо равно 3 символам:
	+ тип метода задаем **int**
	+ в качестве аргумента подаем заданный массив
	+ задаем счетчик - переменную **count**
	+ с помощью цикла **for** перебираем элементы и дополняем счетчик 
	+ в счетчике **for** задаем строковую переменную **strTemp**, равную элементу массива
	+ для перебора элементов создаем условие, где длина строки **strTemp.Length** должна быть меньше или равна трем
	+ возвращаем счетчик **count**

3. Создаем метод **FillArraySelectedItemsAndPrint** по созданию результирующего массива, заполнение его отобранными элементами и вывод нового массива на консоль
	+ тип метода задаем **void**
	+ в качестве аргумента подаем заданный массив
	+ создаем новый массив **newArray** с изначально установленной длиной, равной длине заданного массива
	+ через цикл **for** пробегаем по всем элементам заданного массива 
	+ внутри цикла **for** задаем строковую переменную **strTemp**, равную элементу массива 
	+ задаем переменную **j**, которая является количеством индексов нового массива и вычисляется как найденное количество элементов из метода **SearchItems** минус 1 
	+ для перебора элементов создаем условие, где длина строки **strTemp.Length** должна быть меньше или равна трем
	+ если данное условие соблюдается - присваиваем значение заданного элемента массива  элементу нового массива, делаем отсылку на вывод на консоль данного эле мента
	+ так же в данном методе учитываем вид вывода на консоль согласно заданного примера вывода данных. С ковычками и скобками понятно, а для корректного вывода запятой создаем дополнительное условие **if (i != array.Length - 1)**

4. Задаем первоначальный строковый массив **array** 
5. Выводим первоначальный масссив на консоль с помощью метода **PrintArray** 
6. Для перехода от исходного массива к результирующему выводим на консоль знак **->**
7. Выводим на консоль результирующий массив с отобранными элементами с помощью метода **FillArraySelectedItemsAndPrint**
8. Для читабельного отображения на консоли делаем переход на следующую строку

## Результаты работы программы

["hello", "25", "Russia", "-2", "world", ":-", "dog", "1345", "947"]  ->  ["25", "-2", ":-", "dog", "947"]

## Примечание: 
1. Если выводить на консоль просто заданный  и результирующий vассив, без учета скобок/ковычек/запятых - код значительно сократиться и блок-схемы методов
2. Блок схема общая с применением методов. Блок схемы расшифровки методов в отдельных листах.

