# 💱 Currency Converter (C# Console Application)

A simple **C# console-based currency converter** that allows users to convert amounts between major currencies using predefined exchange rates.

---

## 📌 Features

- Convert currencies **to INR** and **to USD**
- Supported currencies:
  - USD (US Dollar)
  - EURO (Euro)
  - FRANC (Swiss Franc)
  - POUND (British Pound)
- Clear, user-friendly console prompts
- Uses **INR as the base currency** for accurate cross-currency conversion
- Clean control flow using `switch-case`

---

## 🔁 Supported Conversions

1. USD → INR  
2. EURO → INR  
3. FRANC → INR  
4. POUND → INR  
5. INR → USD  
6. EURO → USD  
7. FRANC → USD  

---

## 🧠 Conversion Logic

- **To INR** → Multiply by currency-to-INR rate  
- **From INR** → Divide by USD-to-INR rate  
- **Between non-INR currencies** → Convert via INR  

Example:

EURO → USD
(EURO × EURO_TO_INR) ÷ USD_TO_INR


---

## 🛠 Technologies Used

- Language: **C#**
- Platform: **.NET Console Application**

---

## ▶ How to Run

1. Open the project in **Visual Studio / VS Code**
2. Make sure `.NET SDK` is installed
3. Run the program:
   ```bash
   dotnet run


Select a conversion option
Enter the amount when prompted
View the converted result


🚀 Future Improvements

Live exchange rates using an API
Input validation
Menu loop for multiple conversions
GUI version using WinForms or WPF


👤 Author

MJ
BTech – Information Technology


📄 License

This project is for educational purposes only.


---

### Brutal honesty check  
This README is:
- ✅ Interview-safe  
- ✅ College-submission-ready  
- ✅ Matches your actual code  
- ❌ Not pretending it’s a “real-world financial app” (good)
