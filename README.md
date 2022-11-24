## **Итоговая работа за первый раздел обучение в GeekBrains**
*КУРС РАЗРАБОТЧИК*

### Задачи:
* Проверить полученные знание;
* Подтвердить начальное ознакомление с работой в *GIT*, а также с конролем версий и языками программирования;
* Создать блок-схему алгоритма;
* Решить приведенную задачу с помощью языка программиования C#;
* Осуществить контроль версий;
* Создать сопроводительный текстовый документ (*Markdown*);

### Ход работы:

#### 1. **Создание блок-схемы:**

    Для создания блок-схемы было *Draw.io* -- кроссплатформенное программное обеспечение для рисования графиков с открытым исходным кодом. Его интерфейс можно использовать для создания диаграмм и блок-схемы.

В блок-схеме я отразила ключевой алгоритм решения задачи.

ЗАДАЧА:

    Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 

Главной задачей выполнения алгоритма является сделать так, чтобы из введенного пользователем в массив значений выявить те, у которых количество символов меньше или равно трем. 

На первом этам были введены переменные: 

* string[] arr[i]
* string[] Result[j]
* int i = 0
* int j = 0



Далее выстраиваем цикл, заканчивающийся при *i < arr.Length* (после каждой итерации *i++*), если цикл не закочился, то проверяем длину элемента массива. В случае когда *arr[i].Length <= 3*, то добавляем этот элемент в массив *ResultArr[j]* и после чего увеличиваем *j* на 1, но если условие неправильно, то *i++* и возвращаемя на проверку *i < arr.Length*. 

После прохождения всей длины массива выводим на экран ResultArr, содержащий элементы, длина которого меньше или равна трем.


#### 2. **Создание программы на языке C#**

После создания блок-схемы я начала разработку программы. Язык программирования C#.

        C# — современный объектно-ориентированный и типобезопасный язык программирования.

В первую очередь были созданы функции по 
* Созданию строкового двумерного массива, в котором осуществляется пользовательский ввод элементов. (*CreateArray*)
* Вывод массива (*PrintArray*)
* Ввод пользователем числа (*Prompt*)
* Функция по нахождению элементов в массиве, длина которых меньше 3х символов и созданию массива с этими элементами.

Обращу внимание на последнюю функции, так как она является основополагющей в моей работе. В ней я создала массив ResultArray c элементами <=3 и длиной 0. После каждой итерации, при которых выполнялось условие Array[i].Length <= 3, ResultArray расширялся на один элемент. Для этого был создан временный массив tempArray. 

```C#
string[] ResArray = new string[0];
    for(int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
        string[] tempResArray = new string[ResArray.Length + 1];
            for( int j =0; j< ResArray.Length; j++)
                {
                    tempResArray[j] = ResArray[j]; 
                }

        tempResArray[tempResArray.Length-1] = array[i];
        ResArray = tempResArray;
        }
```
В конце цикла функция возвращает заполненный массив ResultArray.

#### 3. **Создание текстового сопроводительного файла README.md**
## Выводы:

В ходе работы была решена приведенная задача. Созданы блок-схема, удаленный репозиторий с консольным приложением *FinalWork*  и сопроводительный текстовый документ *README.md* Были небольшие трудности с добавлением фото, но и с этим я справились. 

    В предвкушении новых знаний на следующем этапе обучения. Искреннеe спасибо всем преподавателям, кураторам и одногрупникам! 