# Binary Search & Merge Sort in C#

- 🔍 **Binary Search** – efficient searching in a sorted array
- 🧩 **Merge Sort** – stable, recursive sorting algorithm using the divide-and-conquer principle

---

## 📌 Algorithms Overview

### 🔍 Binary Search

Binary Search efficiently finds the position of a target element in a **sorted array** by repeatedly dividing the search interval in half.

- **Time Complexity**: O(log n)
- **Space Complexity**: O(1)
- **Requirement**: Input array must be sorted

### 🧩 Merge Sort

Merge Sort is a **stable sorting algorithm** that divides the input array into halves, sorts them recursively, and then merges them.

- **Time Complexity**: O(n log n)
- **Space Complexity**: O(n)
- **Stable Sort**: ✅ Yes








| Алгоритъм      | Най-добър случай | Среден случай | Най-лош случай | Пространствена сложност | Стабилен |
| -------------- | ---------------- | ------------- | -------------- | ----------------------- | -------- |
| Bubble Sort    | O(n)             | O(n²)         | O(n²)          | O(1)                    | ✅ Да     |
| Insertion Sort | O(n)             | O(n²)         | O(n²)          | O(1)                    | ✅ Да     |
| Selection Sort | O(n²)            | O(n²)         | O(n²)          | O(1)                    | ❌ Не     |
| Merge Sort     | O(n log n)       | O(n log n)    | O(n log n)     | O(n)                    | ✅ Да     |
| Quick Sort     | O(n log n)       | O(n log n)    | O(n²)          | O(log n) (рекурсивно)   | ❌ Не     |
| Heap Sort      | O(n log n)       | O(n log n)    | O(n log n)     | O(1)                    | ❌ Не     |
| Counting Sort  | O(n + k)         | O(n + k)      | O(n + k)       | O(k)                    | ✅ Да     |
| Radix Sort     | O(nk)            | O(nk)         | O(nk)          | O(n + k)                | ✅ Да     |
| Bucket Sort    | O(n + k)         | O(n + k)      | O(n²)          | O(n)                    | ✅ Да     |



17. Какво е Binary Search? Кога работи коректно?
Отговор:
Binary Search е алгоритъм за търсене в сортиран масив. Работи чрез делене на масива наполовина и сравнение със средния елемент.
Условие: Масивът трябва да е сортиран възходящо или низходящо.

Сложност:

Времева: O(log n)

Пространствена: O(1) (итеративно)

18. Сравни List, Dictionary, HashSet – кога коя структура се използва?
    
| Структура         | Описание                         | Времева сложност                            | Уникални стойности      |
| ----------------- | -------------------------------- | ------------------------------------------- | ----------------------- |
| `List<T>`         | Подредена колекция с индекси     | Достъп по индекс: `O(1)`<br>Търсене: `O(n)` | ❌ Не                    |
| `Dictionary<K,V>` | Колекция от двойки ключ-стойност | Достъп по ключ: `O(1)` (в повечето случаи)  | ✅ Да (уникални ключове) |
| `HashSet<T>`      | Колекция от уникални елементи    | Добавяне/търсене: `O(1)`                    | ✅ Да                    |


Използване:

List – когато имаш нужда от подредена последователност

Dictionary – когато искаш бърз достъп по ключ

HashSet – когато искаш уникалност и не те интересува редът

19. Разлика между масив и List<T>

| Характеристика     | Масив (`T[]`)                   | List (`List<T>`)                    |
| ------------------ | ------------------------------- | ----------------------------------- |
| Размер             | Фиксиран                        | Динамичен                           |
| Методи             | Почти няма (`Length`, `CopyTo`) | Богат API (`Add`, `Remove`, `Find`) |
| Производителност   | По-бърз                         | Малко по-бавен                      |
| Случайни стойности | Достъп: `O(1)`                  | Достъп: `O(1)`                      |


20. Какво е LINQ?
Отговор:
LINQ (Language Integrated Query) е вградена в C# технология за заявки към колекции (List, масиви, бази данни, XML и др.), използваща синтаксис подобен на SQL.

Пример:

var results = people.Where(p => p.Age > 30).ToList();

21. Какво е IEnumerable и ICollection?
Интерфейс	Описание
| Интерфейс        | Описание                                                                     |
| ---------------- | ---------------------------------------------------------------------------- |
| `IEnumerable<T>` | Позволява **обхождане** на колекция (foreach). Най-основният интерфейс.      |
| `ICollection<T>` | Наследява `IEnumerable<T>`, добавя методи като `Add()`, `Remove()`, `Count`. |


Пример:

Всички колекции (List, HashSet, Dictionary.Values) имплементират IEnumerable.

List<T> също имплементира ICollection<T>, затова можеш да използваш Add() и Remove().

22. Какво е времева сложност и какво означава O(n), O(log n), O(n²)?
Отговор:
Времевата сложност описва броя на стъпките, които алгоритъмът прави спрямо размера на входа n.

O(1) – константно време (независимо от размера)

O(n) – линейно (нараства пропорционално)

O(log n) – логаритмично (нараства бавно)

O(n²) – квадратично (бавен при големи данни)

O(n log n) – лог-линейно (например Merge Sort)

23. Сложност на for, while, вложени цикли и рекурсия
    
| Конструкция                             | Времева сложност       |
| --------------------------------------- | ---------------------- |
| `for (int i = 0; i < n; i++)`           | O(n)                   |
| Вложен цикъл (`for` в `for`)            | O(n²)                  |
| `while` с делене на 2                   | O(log n)               |
| Рекурсия с 2 извиквания                 | O(2ⁿ) (експоненциална) |
| Рекурсия с 1 извикване и линейна работа | O(n)                   |


24. Кои алгоритми за сортиране са стабилни?
Стабилен алгоритъм = запазва реда на равните елементи.

✅ Стабилни:

Bubble Sort

Insertion Sort

Merge Sort

Counting Sort

Radix Sort

❌ Не са стабилни:

Selection Sort

Heap Sort

Quick Sort (зависи от имплементацията)

25. Каква е сложността на Merge Sort и защо?
Отговор:

Merge Sort разделя списъка на 2 (log n пъти)

Всяко сливане минава през всички елементи (O(n))

👉 Затова общата сложност е O(n log n), дори в най-лошия случай.
Стабилен е и използва допълнителна памет O(n).
