# Solutions Exemples  #

## Введение

Этот README описывает реализацию некоторых алгоритмов сортировки и поиска на примере классов `SortingAlgorithms` и `SearchAlgorithms`. 
Эти алгоритмы представляют собой основные методы сортировки и поиска, которые используются в программировании. Они различаются по сложности, эффективности и области применения.

Класс `SortingAlgorithms` содержит методы для пузырьковой сортировки (`BubbleSort`), шейкерной сортировки (`ShakerSort`), сортировки вставками (`InsertionSort`), сортировки Шелла (`ShellSort`), сортировки методом стога сена (`StoogeSort`), сортировки слиянием (`MergeSort`), сортировки выбором (`SelectionSort`), быстрой сортровки (`QuickSort`), гномьей сортировки (`GnomeSort`), сортировки расчесткой (`CombSort`), сортировки деревом (`TreeSort`).

Класс `SearchAlgorithms` содержит методы для линейного поиск (`LinearSearch`), бинарного поиск (`Binary Search`) и кратчайшего пути от одной вершины графа до всех остальных(Алгоритм Дейкстры)(`DijkstraAlgorithm`)

## Алгоритмы сортировки(SortingAlgorithms)

### Пузырьковая сортировка (`BubbleSort`)

Пузырьковая сортировка является одним из самых простых алгоритмов сортировки. Она работает путём последовательного прохождения по массиву и сравнения соседних элементов. Если элементы расположены в неправильном порядке, они меняются местами. Этот процесс повторяется до тех пор, пока массив не будет полностью отсортирован.

*Лучшее время*: O(n)

*Среднее*: O(n2)

*Худшее*: O(n2)

*Память*: O(1)

### Шейкерная сортировка (`ShakerSort`)

Шейкерная сортировка является улучшенной версией пузырьковой сортировки. Она также работает путём сравнения соседних элементов, но использует два прохода по массиву: прямой и обратный. Это позволяет ускорить процесс сортировки за счёт более эффективного перемещения элементов.

*Лучшее время*: O(n)

*Среднее*: O(n2)

*Худшее*: O(n2)

*Память*: O(n)
### Сортировка вставками (`InsertionSort`)

Сортировка вставками работает путём вставки каждого элемента массива в уже отсортированную часть массива. Это делается путём нахождения правильного места для элемента в отсортированной части и перемещения всех следующих элементов вправо на одну позицию.

*Лучшее время*: O(n)

*Среднее*: O(n2)

*Худшее*: O(n2)

*Память*: O(1)

### Сортировка Шелла (`ShellSort`)

Сортировка Шелла является улучшенной версией сортировки вставками. Она работает путём разделения массива на несколько подмассивов и применения сортировки вставками к каждому из них. Это позволяет ускорить процесс сортировки за счёт более эффективного перемещения элементов.

*Лучшее время*: O(nlog2n)

*Среднее*: Зависит от выбора шага

*Худшее*: O(n2)

*Память*: O(1)
### Сортировка методом стога сена (`StoogeSort`)

Сортировка методом стога сена является одним из самых необычных алгоритмов сортировки. Она работает путём разделения массива на три части, сортировки каждой из них и последующего объединения результатов. Этот процесс повторяется рекурсивно до тех пор, пока массив не будет полностью отсортирован.


*Лучшее время*: O(nlog 3 / log 1.5)

*Среднее*: O(nlog 3 / log 1.5)

*Худшее*: O(nlog 3 / log 1.5)

*Память*: O(n)
### Cортировка слиянием (`MergeSort`)
Сортировка слиянием работает по принципу “разделяй и властвуй”, разбивая входной список на подсписки, сортируя их рекурсивно и объединяя результаты в единый отсортированный список

*Лучшее время*: O(nlogn)

*Среднее*: O(nlogn)

*Худшее*: O(nlogn)

*Память*: O(n)
 (обычная реализация)
O(1)

### Сортировка выбором (`SelectionSort`)
Сортировка выбором работает путём нахождения минимума в текущем списке и обмена его позицией с первым элементом не отсортированного хвоста списка. 

*Лучшее время*: O(n2)

*Среднее*: O(n2)

*Худшее*: O(n2)

*Память*: O(1)
### Быстрая сортировка (`QuickSort`)
Быстрая сортировка так же работает по принципу “разделяй и властвуй”, выбирая опорный элемент и разделяя массив на подмассивы, меньшие и большие опорного. Затем она рекурсивно применяет те же шаги к подмассивам до тех пор, пока массив не будет полностью отсортирован.

*Лучшее время*: O(nlogn)

*Среднее*: O(nlogn)

*Худшее*: O(n2)

*Память*: O(logn)

### Гномья сортировка (`GnomeSort`)
Гномья сортировка похожа на сортировку вставками, но перед вставкой элемента на нужное место происходит серия обменов, как в сортировке пузырьком. Название происходит от предполагаемого поведения садовых гномов при сортировке линии садовых горшков.

*Лучшее время*: O(n)

*Среднее*: O(n2)

*Худшее*: O(n2)

*Память*: O(n)

### Сортировка расческой(`CombSort`)
Сортировка расческой использует комбинацию двух подходов: пузырьковую сортировку для начальных шагов и сортировку вставками для более поздних этапов. Это позволяет достичь высокой эффективности и стабильности сортировки даже для больших массивов.

*Лучшее время*: O(n)

*Среднее*: O(n2/2p)

*Худшее*: O(n2)

*Память*: O(n)

### Сортировка деревом (`TreeSort`)
Алгоритм сортировки с помощью двоичного дерева заключается в построении двоичного дерева поиска по ключам массива, с последующей сборкой результирующего массива путём обхода узлов построенного дерева в необходимом порядке следования ключей.

*Лучшее время*: O(n)

*Среднее*: O(nlogn)

*Худшее*: O(nlogn)

*Память*:O(n)


## Алгоритмы поиска(SearchAlgorithms)
### Линейный поиск (`LinearSearch`)

Алгоритм линейного поиска, который последовательно проверяет каждый элемент массива на соответствие искомому значению.

### Бинарный поиск (`Binary Search`)

Алгоритм бинарного поиска, который ищет элемент в отсортированном массиве, разделяя массив пополам и проверяя, находится ли искомый элемент в левой или правой половине.

### Алгоритм Дейкстры(`DijkstraAlgorithm`)

Метод нахождения кратчайшего пути от одной вершины графа до всех остальных. Он работает путём постепенного расширения множества вершин, для которых известен кратчайший путь от начальной вершины, пока все вершины не будут включены в это множество. На каждом шаге выбирается вершина с наименьшей стоимостью пути от начальной вершины, и эта стоимость обновляется для всех соседних вершин. Процесс повторяется до тех пор, пока все вершины не будут достигнуты или пока не будет найден кратчайший путь до заданной конечной вершины

## Тестирование Алгоритмов
Для всех методов были реализованны Unit-тесты представленный в проете тестов SolutionsExamplesTests(`SolutionsExamplesTests`).
Так же для оценки производительности реализованных алгоритмов сортировки и поиска в рамках проекта, использовалась библиотека BenchmarkDotNet. Это позволило провести сравнительный анализ времени выполнения различных алгоритмов на разных наборах данных, что является ключевым аспектом при выборе оптимального алгоритма для конкретных задач.

Результаты тестов показали, что быстрая сортировка и бинарный поиск являются наиболее эффективными алгоритмами для больших объемов данных, в то время как сортировка пузырьком и линейный поиск подходят для небольших наборов данных или в случаях, когда требуется простота реализации. Эти выводы были сделаны на основе анализа полученных данных Benchmark.

![Вывод после запуска тестов производительности для агоритмов поиска](./SolutionExamples/BenchmarkSearch.PNG "Тесты производительности алгоритмов поиска")

![Вывод после запуска тестов производительности для агоритмов поиска](./SolutionExamples/BenchmarkSorting.PNG "Тесты производительности алгоритмов сортировки")



Использование инструментов Benchmark позволило получить точные и объективные данные о производительности реализованных алгоритмов, что в свою очередь помогло сделать обоснованный выбор в пользу наиболее эффективных решений для различных сценариев использования.

## Заключение

В этом README мы рассмотрели реализацию нескольких алгоритмов сортировки и поиска на примере класса `SortingAlgorithms`. Эти алгоритмы являются основой для многих других алгоритмов и могут быть использованы в различных задачах обработки данных.





