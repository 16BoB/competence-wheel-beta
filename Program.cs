// Метод ссумирования значений элемента массива
int SumTotalScore(int[] arg) {
    int i = 0;
    int length = arg.Length;
    int result = 0;
    while (i < length) {
        result = result + arg[i];
        i++;
    }
    return result;
}

// Портрет специальности программист
int[] programmer = {2, 3, 4, 0, 4, 2, 5, 0, 1, 3, 3, 1, 4, 3, 5};

// Портрет специальности тестировщик
int[] tester = {2, 2, 5, 0, 3, 3, 4, 0, 1, 3, 3, 1, 2, 3, 3};

// Портрет специальности аналитика
int[] analytics = {3, 4, 3, 0, 5, 2, 4, 1, 2, 5, 3, 3, 3, 2, 4};

// Портрет специальности Проджект-менеджер
int[] projectManager = {4, 1, 1, 3, 3, 4, 3, 4, 5, 3, 5, 3, 5, 5, 4};

// Портрет специальности Продакт-менеджер
int[] productManager = {3, 2, 3, 3, 3, 4, 2, 4, 4, 3, 5, 2, 4, 4, 3};

// анкета для ввода балов в конслоь
string[] nameYourCategory = {"1. Введите свой балл критерия - Экстраверт", "2. Введите свой балл критерия - Интроверт", "3. Введите свой балл критерия - Способность к монотонной работе", "4. Введите свой балл критерия - Наставничество", "5. Введите свой балл критерия - Аналитические навыки", "6. Введите свой балл критерия - Эмпатия", "7. Введите свой балл критерия - Любопытство","8. Введите свой балл критерия - Ораточрское искусство", "9. Введите свой балл критерия - Организаторские способности", "10. Введите свой балл критерия - Критическое мышление", "11. Введите свой балл критерия - Многозадачность", "12. Введите свой балл критерия - Креативность", "13. Введите свой балл критерия - Стрессоустойчивость", "14. Введите свой балл критерия - Контроль времени", "15. Введите свой балл критерия - Работа с большим объемом данных"};

// запуск опроса пользователя
int lengthNameYourCat = nameYourCategory.Length;
int i = 0;
int[] arrayYourCateg = new int[15];

while (i < lengthNameYourCat)
{
    Console.WriteLine(nameYourCategory[i]);
    arrayYourCateg[i] = Convert.ToInt32(Console.ReadLine());
    i++;
}

//массив текста для вывода совпадений категорий с профессиями
string[] cmparCategores = {"Совпадении в критерии - экстраверт ", "Совпадении в критерии - интроверт ","Совпадении в критерии - Способность к монотонной работе ","Совпадении в критерии - Наставничество ","Совпадении в критерии - Аналитические навыки ","Совпадении в критерии - Эмпатия ","Совпадении в критерии - Любопытство ","Совпадении в критерии - Ораточрское искусство ","Совпадении в критерии - Организаторские способности ","Совпадении в критерии - Критическое мышление ","Совпадении в критерии - Многозадачность ","Совпадении в критерии - Креативность ","Совпадении в критерии - Стрессоустойчивость ","Совпадении в критерии - Контроль времени ","Совпадении в критерии - Работа с большим объемом данных "};

//метод сверки совадений с профессией
//Первым аргументом класть массив пользователя, вторым массив профессии, третим массив текста вывода
void compareСategories(int[] arr1, int[] arr2, string[] arr3) {
    int[] compareArray = new int[15];
    int j = 0;
    int lengthArr = arr1.Length;
    while (j < lengthArr) {
        if (arr1[j] >= arr2[j]) {
            compareArray[j] = arr2[j];
            Console.WriteLine(arr3[j] + arr2[j]);
        }
        else {
            compareArray[j] = arr1[j];
            Console.WriteLine(arr3[j] + arr1[j]);
        }
        j++;
    }
    double result1 = SumTotalScore(arr2);
    double result2 = SumTotalScore(compareArray);
    double result3 = result2 / result1 * 100;
    Console.WriteLine("Ваше совпадение " + result2 + " из " + result1 + " совпадение " + result3 + "%");
    Console.WriteLine(" ");
    Console.WriteLine(" ");
}


Console.WriteLine("Совпадения с программистом");
compareСategories(arrayYourCateg, programmer, cmparCategores);

Console.WriteLine("Совпадения с тестирощиком");
compareСategories(arrayYourCateg, tester, cmparCategores);

Console.WriteLine("Совпадения с аналитиком");
compareСategories(arrayYourCateg, analytics, cmparCategores);

Console.WriteLine("Совпадения с проджект-менеджером");
compareСategories(arrayYourCateg, projectManager, cmparCategores);

Console.WriteLine("Совпадения с продукт-менеджером");
compareСategories(arrayYourCateg, productManager, cmparCategores);