# C# File Handling

## Introduction

File handling is an important concept in C# programming. It allows applications to read, create, update, and delete files stored on a computer.

This assignment focuses on two main concepts:

1. Other File Reading Methods.
2. Deleting Files and Items Inside Files.

The practical examples are implemented using a Windows Forms Application in Visual Studio 2022.

---

## 1. Other File Reading Methods in C#

C# provides different methods for reading text files. This assignment focuses on `ReadAllLines()` and `ReadLines()`.

### 1.1 ReadAllLines()

The `File.ReadAllLines()` method reads all lines from a text file and stores them in a string array.

Each line is stored as a separate element in the array. This method is useful when the application needs to access all lines at once.

### 1.2 ReadLines()

The `File.ReadLines()` method returns the lines of a text file as an enumerable sequence.

Unlike `ReadAllLines()`, it allows lines to be processed without loading the entire file into memory at once. This makes it useful when working with large text files.

### Difference Between ReadAllLines() and ReadLines()

* `ReadAllLines()` reads all lines and stores them in a string array.
* `ReadLines()` provides the lines as a sequence that can be processed one at a time.

Both methods can be used to process text files line by line.

---

## 2. Deleting Files and Items Inside Files

### 2.1 Deleting Files

The `File.Delete()` method is used to delete an entire file from its location.

Before deleting a file, the application can use `File.Exists()` to check whether the file exists.

Example:

```csharp
if (File.Exists("Index.txt"))
{
    File.Delete("Index.txt");
    MessageBox.Show("File deleted successfully!");
}
else
{
    MessageBox.Show("File not found!");
}
```

This example checks whether the file exists before attempting to delete it.

### 2.2 Deleting Items Inside Files

Deleting items inside a file means removing specific information while keeping the file itself.

For example, if a text file contains student names, the application can remove a selected student's name and save the remaining names back to the file.

C# does not provide a general `File.DeleteItem()` method. Instead, methods such as `File.ReadAllLines()` and `File.WriteAllLines()` can be used to read the file, remove the selected item, and save the updated contents.

This approach is useful for managing student names, employee records, and other text-based information.

### Difference Between Deleting Files and Deleting Items

* **Deleting a file:** Removes the entire file from the computer.
* **Deleting an item:** Removes selected information while keeping the file and its remaining contents.

---

## 3. Technologies Used

* C#
* Windows Forms
* Visual Studio 2022
* System.IO Namespace
* Text Files (.txt)

---

## Conclusion

C# provides several methods for reading and managing text files.

The `File.ReadAllLines()` and `File.ReadLines()` methods are useful for reading file contents, while `File.Delete()` removes an entire file.

To delete specific information inside a file, the application can read the contents, filter out the selected item, and write the remaining information back to the file.

These methods help developers manage text files effectively in Windows Forms applications.
