Here’s a clean and elegant **README.md** for your `UnCipher` project that explains the purpose, usage, and structure of your Atbash cipher decoder:

---

## 🔐 UnCipher

**UnCipher** is a simple C# console application that decodes sentences using the [Atbash Cipher](https://en.wikipedia.org/wiki/Atbash), a classical encryption method where each letter is substituted with its mirror equivalent in the alphabet. For example, `a ↔ z`, `b ↔ y`, `c ↔ x`, and so on.

---

### 📜 Description

The purpose of **UnCipher** is to:

* Allow the user to input multiple encoded sentences using the Atbash cipher.
* Decode and display each sentence in its original, readable form.
* Reinforce how substitution ciphers work in a hands-on, beginner-friendly way.

---

### 🧪 How It Works

1. The user is prompted to enter the number of sentences they'd like to decode.
2. For each sentence, the user inputs a lowercase Atbash-encoded string.
3. The application processes each sentence, reversing each lowercase character (keeping spaces and punctuation unchanged).
4. Decoded sentences are then printed out in a formatted display.

---

### ✅ Example

**Input:**

```
gsv xlwv gl nvhhztv
```

**Output:**

```
the code to message
```

---

### ▶️ How to Run

1. Open the project in Visual Studio or your preferred C# IDE.
2. Build and run the application.
3. Follow the prompts in the terminal to input your encoded sentences.
4. View the decoded output in a stylish console format.

---

### 🛠️ Features

* ✔ Multiple input support
* ✔ Color-coded console UI
* ✔ Preserves spaces and special characters
* ✔ Simple logic with clear method separation

---

### 🧠 Educational Value

This project is great for:

* Understanding basic cryptographic concepts.
* Practicing loops, string manipulation, and character encoding in C#.
* Exploring how classic ciphers can be implemented programmatically.

---

### 📁 File Structure

```
UnCipher/
│
├── Program.cs        # Main logic for input, decoding, and output
├── README.md         # Project documentation (you are here)
```

---

### ✍️ Author

Developed by **Hailey Jade Govender**
Built with ❤️ for learning and fun.

---
