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
