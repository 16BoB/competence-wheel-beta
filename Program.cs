// Метод ссумирования
int SumTotalScore(int[] arg,int arg2) {
    int i = 0;
    int length = arg.Length;
    while (i < length) {
        arg2 = arg2 + arg[i];
        i++;
    }
    return arg2;
}

// Портрет специальности программист
// int programmerTotalScore = 40;
int[] programmer = {2, 3, 4, 0, 4, 2, 5, 0, 1, 3, 3, 1, 4, 3, 5};

// Портрет специальности тестировщик
// int testerTotalScore = 35;
int[] tester = {2, 2, 5, 0, 3, 3, 4, 0, 1, 3, 3, 1, 2, 3, 3};

// Портрет специальности аналитика
// int analyticsTotalScore = 44;
int[] analytics = {3, 4, 3, 0, 5, 2, 4, 1, 2, 5, 3, 3, 3, 2, 4};

// Портрет специальности Проджект-менеджер
// int projectManagerTotalScore = 53;
int[] projectManager = {4, 1, 1, 3, 3, 4, 3, 4, 5, 3, 5, 3, 5, 5, 4};

// Портрет специальности Продакт-менеджер
// int productManagerTotalScore = 49;
int[] productManager = {3, 2, 3, 3, 3, 4, 2, 4, 4, 3, 5, 2, 4, 4, 3};

int totalScore = 0;

string[] nameYourCategory = {"1. Введите свой балл критерия - Экстраверт", "2. Введите свой балл критерия - Интроверт", "3. Введите свой балл критерия - Способность к монотонной работе", "4. Введите свой балл критерия - Наставничество", "5. Введите свой балл критерия - Аналитические навыки", "6. Введите свой балл критерия - Эмпатия", "7. Введите свой балл критерия - Любопытство","8. Введите свой балл критерия - Ораточрское искусство", "9. Введите свой балл критерия - Организаторские способности", "10. Введите свой балл критерия - Критическое мышление", "11. Введите свой балл критерия - Многозадачность", "12. Введите свой балл критерия - Креативность", "13. Введите свой балл критерия - Стрессоустойчивость", "14. Введите свой балл критерия - Контроль времени", "15. Введите свой балл критерия - Работа с большим объемом данных"};

int lengthNameYourCat = nameYourCategory.Length;
int i = 0;
int[] arrayYourCateg = new int[15];
int lengthArrayYourCateg = arrayYourCateg.Length;

while (i < lengthNameYourCat)
{
    Console.WriteLine(nameYourCategory[i]);
    arrayYourCateg[i] = Convert.ToInt32(Console.ReadLine());
    i++;
}

// int j = 0;

// while (j <lengthArrayYourCateg)
// {
//     Console.WriteLine(arrayYourCateg[j]);
//     j++;
// }


// // // посчет баллов для проверки
// // int your_total_score = extrovert + introvert + аbility_to_work_monotonously + мentoring + analytical_data + empathy + curiosity + oratory + organizational_ability + critical_thinking + multitasking + creativity + stress_tolerance + time_control + work_with_a_large_amount_of_data;
// // Console.WriteLine(your_total_score);

// // сверка совадений с программистом
// Console.WriteLine("Совпадения с программистом");

// int coincidence_with_the_programmer_extrovert;

// if (extrovert >= programmer_extrovert)
// {
//     coincidence_with_the_programmer_extrovert = programmer_extrovert;
// }
// else
// {
//     coincidence_with_the_programmer_extrovert = extrovert;
// }

// Console.WriteLine("Совпадении в критерии - экстраверт " + coincidence_with_the_programmer_extrovert);

// int coincidence_with_the_programmer_introvert;

// if (introvert >= programmer_introvert)
// {
//     coincidence_with_the_programmer_introvert = programmer_introvert;
// }
// else
// {
//     coincidence_with_the_programmer_introvert = introvert;
// }

// Console.WriteLine("Совпадении в критерии - интроверт " + coincidence_with_the_programmer_introvert);

// int coincidence_with_the_programmer_аbility_to_work_monotonously;

// if (аbility_to_work_monotonously >= programmer_аbility_to_work_monotonously)
// {
//     coincidence_with_the_programmer_аbility_to_work_monotonously = programmer_аbility_to_work_monotonously;
// }
// else
// {
//     coincidence_with_the_programmer_аbility_to_work_monotonously = аbility_to_work_monotonously;
// }

// Console.WriteLine("Совпадении в критерии - Способность к монотонной работе " + coincidence_with_the_programmer_аbility_to_work_monotonously);

// int coincidence_with_the_programmer_мentoring;

// if (мentoring >= programmer_мentoring)
// {
//     coincidence_with_the_programmer_мentoring = programmer_мentoring;
// }
// else
// {
//     coincidence_with_the_programmer_мentoring = мentoring;
// }

// Console.WriteLine("Совпадении в критерии - Наставничество " + coincidence_with_the_programmer_мentoring);

// int coincidence_with_the_programmer_analytical_data;

// if (analytical_data >= programmer_analytical_data)
// {
//     coincidence_with_the_programmer_analytical_data = programmer_analytical_data;
// }
// else
// {
//     coincidence_with_the_programmer_analytical_data = analytical_data;
// }

// Console.WriteLine("Совпадении в критерии - Аналитические навыки " + coincidence_with_the_programmer_analytical_data);

// int coincidence_with_the_programmer_empathy;

// if (empathy >= programmer_empathy)
// {
//     coincidence_with_the_programmer_empathy = programmer_empathy;
// }
// else
// {
//     coincidence_with_the_programmer_empathy = empathy;
// }

// Console.WriteLine("Совпадении в критерии - Эмпатия " + coincidence_with_the_programmer_empathy);

// int coincidence_with_the_programmer_curiosity;

// if (curiosity >= programmer_curiosity)
// {
//     coincidence_with_the_programmer_curiosity = programmer_curiosity;
// }
// else
// {
//     coincidence_with_the_programmer_curiosity = curiosity;
// }

// Console.WriteLine("Совпадении в критерии - Любопытство " + coincidence_with_the_programmer_curiosity);

// int coincidence_with_the_programmer_oratory;

// if (oratory >= programmer_oratory)
// {
//     coincidence_with_the_programmer_oratory = programmer_oratory;
// }
// else
// {
//     coincidence_with_the_programmer_oratory = oratory;
// }

// Console.WriteLine("Совпадении в критерии - Ораточрское искусство " + coincidence_with_the_programmer_oratory);

// int coincidence_with_the_programmer_organizational_ability;

// if (organizational_ability >= programmer_organizational_ability)
// {
//     coincidence_with_the_programmer_organizational_ability = programmer_organizational_ability;
// }
// else
// {
//     coincidence_with_the_programmer_organizational_ability = organizational_ability;
// }

// Console.WriteLine("Совпадении в критерии - Организаторские способности " + coincidence_with_the_programmer_organizational_ability);

// int coincidence_with_the_programmer_critical_thinking;

// if (critical_thinking >= programmer_critical_thinking)
// {
//     coincidence_with_the_programmer_critical_thinking = programmer_critical_thinking;
// }
// else
// {
//     coincidence_with_the_programmer_critical_thinking = critical_thinking;
// }

// Console.WriteLine("Совпадении в критерии - Критическое мышление " + coincidence_with_the_programmer_critical_thinking);

// int coincidence_with_the_programmer_multitasking;

// if (multitasking >= programmer_multitasking)
// {
//     coincidence_with_the_programmer_multitasking = programmer_multitasking;
// }
// else
// {
//     coincidence_with_the_programmer_multitasking = multitasking;
// }

// Console.WriteLine("Совпадении в критерии - Многозадачность " + coincidence_with_the_programmer_multitasking);

// int coincidence_with_the_programmer_creativity;

// if (creativity >= programmer_creativity)
// {
//     coincidence_with_the_programmer_creativity = programmer_creativity;
// }
// else
// {
//     coincidence_with_the_programmer_creativity = creativity;
// }

// Console.WriteLine("Совпадении в критерии - Креативность " + coincidence_with_the_programmer_creativity);

// int coincidence_with_the_programmer_stress_tolerance;

// if (stress_tolerance >= programmer_stress_tolerance)
// {
//     coincidence_with_the_programmer_stress_tolerance = programmer_stress_tolerance;
// }
// else
// {
//     coincidence_with_the_programmer_stress_tolerance = stress_tolerance;
// }

// Console.WriteLine("Совпадении в критерии - Стрессоустойчивость " + coincidence_with_the_programmer_stress_tolerance);

// int coincidence_with_the_programmer_time_control;

// if (time_control >= programmer_time_control)
// {
//     coincidence_with_the_programmer_time_control = programmer_time_control;
// }
// else
// {
//     coincidence_with_the_programmer_time_control = time_control;
// }

// Console.WriteLine("Совпадении в критерии - Контроль времени " + coincidence_with_the_programmer_time_control);

// int coincidence_with_the_programmer_work_with_a_large_amount_of_data;

// if (work_with_a_large_amount_of_data >= programmer_work_with_a_large_amount_of_data)
// {
//     coincidence_with_the_programmer_work_with_a_large_amount_of_data = programmer_work_with_a_large_amount_of_data;
// }
// else
// {
//     coincidence_with_the_programmer_work_with_a_large_amount_of_data = work_with_a_large_amount_of_data;
// }

// Console.WriteLine("Совпадении в критерии - Работа с большим объемом данных " + coincidence_with_the_programmer_work_with_a_large_amount_of_data);

// int final_match_with_the_programmer = coincidence_with_the_programmer_extrovert +
// coincidence_with_the_programmer_introvert +
// coincidence_with_the_programmer_аbility_to_work_monotonously +
// coincidence_with_the_programmer_мentoring +
// coincidence_with_the_programmer_analytical_data +
// coincidence_with_the_programmer_empathy +
// coincidence_with_the_programmer_curiosity +
// coincidence_with_the_programmer_oratory +
// coincidence_with_the_programmer_organizational_ability +
// coincidence_with_the_programmer_critical_thinking +
// coincidence_with_the_programmer_multitasking +
// coincidence_with_the_programmer_creativity +
// coincidence_with_the_programmer_stress_tolerance +
// coincidence_with_the_programmer_time_control +
// coincidence_with_the_programmer_work_with_a_large_amount_of_data;

// double match_percentage_programmer = ((double)final_match_with_the_programmer)/programmer_total_score*100;

// Console.WriteLine("Ваше совпадение " + final_match_with_the_programmer + " из " + programmer_total_score + " совпадение " + match_percentage_programmer + "%");
// Console.WriteLine(" ");
// Console.WriteLine(" ");

// // сверка совадений с тестировщиком
// Console.WriteLine("Совпадения с тестировщиком");

// int coincidence_with_the_tester_extrovert;

// if (extrovert >= tester_extrovert)
// {
//     coincidence_with_the_tester_extrovert = tester_extrovert;
// }
// else
// {
//     coincidence_with_the_tester_extrovert = extrovert;
// }

// Console.WriteLine("Совпадении в критерии - экстраверт " + coincidence_with_the_tester_extrovert);

// int coincidence_with_the_tester_introvert;

// if (introvert >= tester_introvert)
// {
//     coincidence_with_the_tester_introvert = tester_introvert;
// }
// else
// {
//     coincidence_with_the_tester_introvert = introvert;
// }

// Console.WriteLine("Совпадении в критерии - интроверт " + coincidence_with_the_tester_introvert);

// int coincidence_with_the_tester_аbility_to_work_monotonously;

// if (аbility_to_work_monotonously >= tester_аbility_to_work_monotonously)
// {
//     coincidence_with_the_tester_аbility_to_work_monotonously = tester_аbility_to_work_monotonously;
// }
// else
// {
//     coincidence_with_the_tester_аbility_to_work_monotonously = аbility_to_work_monotonously;
// }

// Console.WriteLine("Совпадении в критерии - Способность к монотонной работе " + coincidence_with_the_tester_аbility_to_work_monotonously);

// int coincidence_with_the_tester_мentoring;

// if (мentoring >= tester_мentoring)
// {
//     coincidence_with_the_tester_мentoring = tester_мentoring;
// }
// else
// {
//     coincidence_with_the_tester_мentoring = мentoring;
// }

// Console.WriteLine("Совпадении в критерии - Наставничество " + coincidence_with_the_tester_мentoring);

// int coincidence_with_the_tester_analytical_data;

// if (analytical_data >= tester_analytical_data)
// {
//     coincidence_with_the_tester_analytical_data = tester_analytical_data;
// }
// else
// {
//     coincidence_with_the_tester_analytical_data = analytical_data;
// }

// Console.WriteLine("Совпадении в критерии - Аналитические навыки " + coincidence_with_the_tester_analytical_data);

// int coincidence_with_the_tester_empathy;

// if (empathy >= tester_empathy)
// {
//     coincidence_with_the_tester_empathy = tester_empathy;
// }
// else
// {
//     coincidence_with_the_tester_empathy = empathy;
// }

// Console.WriteLine("Совпадении в критерии - Эмпатия " + coincidence_with_the_tester_empathy);

// int coincidence_with_the_tester_curiosity;

// if (curiosity >= tester_curiosity)
// {
//     coincidence_with_the_tester_curiosity = tester_curiosity;
// }
// else
// {
//     coincidence_with_the_tester_curiosity = curiosity;
// }

// Console.WriteLine("Совпадении в критерии - Любопытство " + coincidence_with_the_tester_curiosity);

// int coincidence_with_the_tester_oratory;

// if (oratory >= tester_oratory)
// {
//     coincidence_with_the_tester_oratory = tester_oratory;
// }
// else
// {
//     coincidence_with_the_tester_oratory = oratory;
// }

// Console.WriteLine("Совпадении в критерии - Ораточрское искусство " + coincidence_with_the_tester_oratory);

// int coincidence_with_the_tester_organizational_ability;

// if (organizational_ability >= tester_organizational_ability)
// {
//     coincidence_with_the_tester_organizational_ability = tester_organizational_ability;
// }
// else
// {
//     coincidence_with_the_tester_organizational_ability = organizational_ability;
// }

// Console.WriteLine("Совпадении в критерии - Организаторские способности " + coincidence_with_the_tester_organizational_ability);

// int coincidence_with_the_tester_critical_thinking;

// if (critical_thinking >= tester_critical_thinking)
// {
//     coincidence_with_the_tester_critical_thinking = tester_critical_thinking;
// }
// else
// {
//     coincidence_with_the_tester_critical_thinking = critical_thinking;
// }

// Console.WriteLine("Совпадении в критерии - Критическое мышление " + coincidence_with_the_tester_critical_thinking);

// int coincidence_with_the_tester_multitasking;

// if (multitasking >= tester_multitasking)
// {
//     coincidence_with_the_tester_multitasking = tester_multitasking;
// }
// else
// {
//     coincidence_with_the_tester_multitasking = multitasking;
// }

// Console.WriteLine("Совпадении в критерии - Многозадачность " + coincidence_with_the_tester_multitasking);

// int coincidence_with_the_tester_creativity;

// if (creativity >= tester_creativity)
// {
//     coincidence_with_the_tester_creativity = tester_creativity;
// }
// else
// {
//     coincidence_with_the_tester_creativity = creativity;
// }

// Console.WriteLine("Совпадении в критерии - Креативность " + coincidence_with_the_tester_creativity);

// int coincidence_with_the_tester_stress_tolerance;

// if (stress_tolerance >= tester_stress_tolerance)
// {
//     coincidence_with_the_tester_stress_tolerance = tester_stress_tolerance;
// }
// else
// {
//     coincidence_with_the_tester_stress_tolerance = stress_tolerance;
// }

// Console.WriteLine("Совпадении в критерии - Стрессоустойчивость " + coincidence_with_the_tester_stress_tolerance);

// int coincidence_with_the_tester_time_control;

// if (time_control >= tester_time_control)
// {
//     coincidence_with_the_tester_time_control = tester_time_control;
// }
// else
// {
//     coincidence_with_the_tester_time_control = time_control;
// }

// Console.WriteLine("Совпадении в критерии - Контроль времени " + coincidence_with_the_tester_time_control);

// int coincidence_with_the_tester_work_with_a_large_amount_of_data;

// if (work_with_a_large_amount_of_data >= tester_work_with_a_large_amount_of_data)
// {
//     coincidence_with_the_tester_work_with_a_large_amount_of_data = tester_work_with_a_large_amount_of_data;
// }
// else
// {
//     coincidence_with_the_tester_work_with_a_large_amount_of_data = work_with_a_large_amount_of_data;
// }

// Console.WriteLine("Совпадении в критерии - Работа с большим объемом данных " + coincidence_with_the_tester_work_with_a_large_amount_of_data);

// int final_match_with_the_tester = coincidence_with_the_tester_extrovert +
// coincidence_with_the_tester_introvert +
// coincidence_with_the_tester_аbility_to_work_monotonously +
// coincidence_with_the_tester_мentoring +
// coincidence_with_the_tester_analytical_data +
// coincidence_with_the_tester_empathy +
// coincidence_with_the_tester_curiosity +
// coincidence_with_the_tester_oratory +
// coincidence_with_the_tester_organizational_ability +
// coincidence_with_the_tester_critical_thinking +
// coincidence_with_the_tester_multitasking +
// coincidence_with_the_tester_creativity +
// coincidence_with_the_tester_stress_tolerance +
// coincidence_with_the_tester_time_control +
// coincidence_with_the_tester_work_with_a_large_amount_of_data;

// double match_percentage_tester = ((double)final_match_with_the_tester)/tester_total_score*100;

// Console.WriteLine("Ваше совпадение " + final_match_with_the_tester + " из " + tester_total_score + " совпадение " + match_percentage_tester + "%");
// Console.WriteLine(" ");
// Console.WriteLine(" ");

// // сверка совадений с аналитиком
// Console.WriteLine("Совпадения с аналитиком");

// int coincidence_with_the_analytics_extrovert;

// if (extrovert >= analytics_extrovert)
// {
//     coincidence_with_the_analytics_extrovert = analytics_extrovert;
// }
// else
// {
//     coincidence_with_the_analytics_extrovert = extrovert;
// }

// Console.WriteLine("Совпадении в критерии - экстраверт " + coincidence_with_the_analytics_extrovert);

// int coincidence_with_the_analytics_introvert;

// if (introvert >= analytics_introvert)
// {
//     coincidence_with_the_analytics_introvert = analytics_introvert;
// }
// else
// {
//     coincidence_with_the_analytics_introvert = introvert;
// }

// Console.WriteLine("Совпадении в критерии - интроверт " + coincidence_with_the_analytics_introvert);

// int coincidence_with_the_analytics_аbility_to_work_monotonously;

// if (аbility_to_work_monotonously >= analytics_аbility_to_work_monotonously)
// {
//     coincidence_with_the_analytics_аbility_to_work_monotonously = analytics_аbility_to_work_monotonously;
// }
// else
// {
//     coincidence_with_the_analytics_аbility_to_work_monotonously = аbility_to_work_monotonously;
// }

// Console.WriteLine("Совпадении в критерии - Способность к монотонной работе " + coincidence_with_the_analytics_аbility_to_work_monotonously);

// int coincidence_with_the_analytics_мentoring;

// if (мentoring >= analytics_мentoring)
// {
//     coincidence_with_the_analytics_мentoring = analytics_мentoring;
// }
// else
// {
//     coincidence_with_the_analytics_мentoring = мentoring;
// }

// Console.WriteLine("Совпадении в критерии - Наставничество " + coincidence_with_the_analytics_мentoring);

// int coincidence_with_the_analytics_analytical_data;

// if (analytical_data >= analytics_analytical_data)
// {
//     coincidence_with_the_analytics_analytical_data = analytics_analytical_data;
// }
// else
// {
//     coincidence_with_the_analytics_analytical_data = analytical_data;
// }

// Console.WriteLine("Совпадении в критерии - Аналитические навыки " + coincidence_with_the_analytics_analytical_data);

// int coincidence_with_the_analytics_empathy;

// if (empathy >= analytics_empathy)
// {
//     coincidence_with_the_analytics_empathy = analytics_empathy;
// }
// else
// {
//     coincidence_with_the_analytics_empathy = empathy;
// }

// Console.WriteLine("Совпадении в критерии - Эмпатия " + coincidence_with_the_analytics_empathy);

// int coincidence_with_the_analytics_curiosity;

// if (curiosity >= analytics_curiosity)
// {
//     coincidence_with_the_analytics_curiosity = analytics_curiosity;
// }
// else
// {
//     coincidence_with_the_analytics_curiosity = curiosity;
// }

// Console.WriteLine("Совпадении в критерии - Любопытство " + coincidence_with_the_analytics_curiosity);

// int coincidence_with_the_analytics_oratory;

// if (oratory >= analytics_oratory)
// {
//     coincidence_with_the_analytics_oratory = analytics_oratory;
// }
// else
// {
//     coincidence_with_the_analytics_oratory = oratory;
// }

// Console.WriteLine("Совпадении в критерии - Ораточрское искусство " + coincidence_with_the_analytics_oratory);

// int coincidence_with_the_analytics_organizational_ability;

// if (organizational_ability >= analytics_organizational_ability)
// {
//     coincidence_with_the_analytics_organizational_ability = analytics_organizational_ability;
// }
// else
// {
//     coincidence_with_the_analytics_organizational_ability = organizational_ability;
// }

// Console.WriteLine("Совпадении в критерии - Организаторские способности " + coincidence_with_the_analytics_organizational_ability);

// int coincidence_with_the_analytics_critical_thinking;

// if (critical_thinking >= analytics_critical_thinking)
// {
//     coincidence_with_the_analytics_critical_thinking = analytics_critical_thinking;
// }
// else
// {
//     coincidence_with_the_analytics_critical_thinking = critical_thinking;
// }

// Console.WriteLine("Совпадении в критерии - Критическое мышление " + coincidence_with_the_analytics_critical_thinking);

// int coincidence_with_the_analytics_multitasking;

// if (multitasking >= analytics_multitasking)
// {
//     coincidence_with_the_analytics_multitasking = analytics_multitasking;
// }
// else
// {
//     coincidence_with_the_analytics_multitasking = multitasking;
// }

// Console.WriteLine("Совпадении в критерии - Многозадачность " + coincidence_with_the_analytics_multitasking);

// int coincidence_with_the_analytics_creativity;

// if (creativity >= analytics_creativity)
// {
//     coincidence_with_the_analytics_creativity = analytics_creativity;
// }
// else
// {
//     coincidence_with_the_analytics_creativity = creativity;
// }

// Console.WriteLine("Совпадении в критерии - Креативность " + coincidence_with_the_analytics_creativity);

// int coincidence_with_the_analytics_stress_tolerance;

// if (stress_tolerance >= analytics_stress_tolerance)
// {
//     coincidence_with_the_analytics_stress_tolerance = analytics_stress_tolerance;
// }
// else
// {
//     coincidence_with_the_analytics_stress_tolerance = stress_tolerance;
// }

// Console.WriteLine("Совпадении в критерии - Стрессоустойчивость " + coincidence_with_the_analytics_stress_tolerance);

// int coincidence_with_the_analytics_time_control;

// if (time_control >= analytics_time_control)
// {
//     coincidence_with_the_analytics_time_control = analytics_time_control;
// }
// else
// {
//     coincidence_with_the_analytics_time_control = time_control;
// }

// Console.WriteLine("Совпадении в критерии - Контроль времени " + coincidence_with_the_analytics_time_control);

// int coincidence_with_the_analytics_work_with_a_large_amount_of_data;

// if (work_with_a_large_amount_of_data >= analytics_work_with_a_large_amount_of_data)
// {
//     coincidence_with_the_analytics_work_with_a_large_amount_of_data = analytics_work_with_a_large_amount_of_data;
// }
// else
// {
//     coincidence_with_the_analytics_work_with_a_large_amount_of_data = work_with_a_large_amount_of_data;
// }

// Console.WriteLine("Совпадении в критерии - Работа с большим объемом данных " + coincidence_with_the_analytics_work_with_a_large_amount_of_data);

// int final_match_with_the_analytics = coincidence_with_the_analytics_extrovert +
// coincidence_with_the_analytics_introvert +
// coincidence_with_the_analytics_аbility_to_work_monotonously +
// coincidence_with_the_analytics_мentoring +
// coincidence_with_the_analytics_analytical_data +
// coincidence_with_the_analytics_empathy +
// coincidence_with_the_analytics_curiosity +
// coincidence_with_the_analytics_oratory +
// coincidence_with_the_analytics_organizational_ability +
// coincidence_with_the_analytics_critical_thinking +
// coincidence_with_the_analytics_multitasking +
// coincidence_with_the_analytics_creativity +
// coincidence_with_the_analytics_stress_tolerance +
// coincidence_with_the_analytics_time_control +
// coincidence_with_the_analytics_work_with_a_large_amount_of_data;

// double match_percentage_analytics = ((double)final_match_with_the_analytics)/analytics_total_score*100;

// Console.WriteLine("Ваше совпадение " + final_match_with_the_analytics + " из " + analytics_total_score + " совпадение " + match_percentage_analytics + "%");
// Console.WriteLine(" ");
// Console.WriteLine(" ");

// // сверка совадений с проджект-менеджер
// Console.WriteLine("Совпадения с проджект-менеджер");

// int coincidence_with_the_project_manager_extrovert;

// if (extrovert >= project_manager_extrovert)
// {
//     coincidence_with_the_project_manager_extrovert = project_manager_extrovert;
// }
// else
// {
//     coincidence_with_the_project_manager_extrovert = extrovert;
// }

// Console.WriteLine("Совпадении в критерии - экстраверт " + coincidence_with_the_project_manager_extrovert);

// int coincidence_with_the_project_manager_introvert;

// if (introvert >= project_manager_introvert)
// {
//     coincidence_with_the_project_manager_introvert = project_manager_introvert;
// }
// else
// {
//     coincidence_with_the_project_manager_introvert = introvert;
// }

// Console.WriteLine("Совпадении в критерии - интроверт " + coincidence_with_the_project_manager_introvert);

// int coincidence_with_the_project_manager_аbility_to_work_monotonously;

// if (аbility_to_work_monotonously >= project_manager_аbility_to_work_monotonously)
// {
//     coincidence_with_the_project_manager_аbility_to_work_monotonously = project_manager_аbility_to_work_monotonously;
// }
// else
// {
//     coincidence_with_the_project_manager_аbility_to_work_monotonously = аbility_to_work_monotonously;
// }

// Console.WriteLine("Совпадении в критерии - Способность к монотонной работе " + coincidence_with_the_project_manager_аbility_to_work_monotonously);

// int coincidence_with_the_project_manager_мentoring;

// if (мentoring >= project_manager_мentoring)
// {
//     coincidence_with_the_project_manager_мentoring = project_manager_мentoring;
// }
// else
// {
//     coincidence_with_the_project_manager_мentoring = мentoring;
// }

// Console.WriteLine("Совпадении в критерии - Наставничество " + coincidence_with_the_project_manager_мentoring);

// int coincidence_with_the_project_manager_analytical_data;

// if (analytical_data >= project_manager_analytical_data)
// {
//     coincidence_with_the_project_manager_analytical_data = project_manager_analytical_data;
// }
// else
// {
//     coincidence_with_the_project_manager_analytical_data = analytical_data;
// }

// Console.WriteLine("Совпадении в критерии - Аналитические навыки " + coincidence_with_the_project_manager_analytical_data);

// int coincidence_with_the_project_manager_empathy;

// if (empathy >= project_manager_empathy)
// {
//     coincidence_with_the_project_manager_empathy = project_manager_empathy;
// }
// else
// {
//     coincidence_with_the_project_manager_empathy = empathy;
// }

// Console.WriteLine("Совпадении в критерии - Эмпатия " + coincidence_with_the_project_manager_empathy);

// int coincidence_with_the_project_manager_curiosity;

// if (curiosity >= project_manager_curiosity)
// {
//     coincidence_with_the_project_manager_curiosity = project_manager_curiosity;
// }
// else
// {
//     coincidence_with_the_project_manager_curiosity = curiosity;
// }

// Console.WriteLine("Совпадении в критерии - Любопытство " + coincidence_with_the_project_manager_curiosity);

// int coincidence_with_the_project_manager_oratory;

// if (oratory >= project_manager_oratory)
// {
//     coincidence_with_the_project_manager_oratory = project_manager_oratory;
// }
// else
// {
//     coincidence_with_the_project_manager_oratory = oratory;
// }

// Console.WriteLine("Совпадении в критерии - Ораточрское искусство " + coincidence_with_the_project_manager_oratory);

// int coincidence_with_the_project_manager_organizational_ability;

// if (organizational_ability >= project_manager_organizational_ability)
// {
//     coincidence_with_the_project_manager_organizational_ability = project_manager_organizational_ability;
// }
// else
// {
//     coincidence_with_the_project_manager_organizational_ability = organizational_ability;
// }

// Console.WriteLine("Совпадении в критерии - Организаторские способности " + coincidence_with_the_project_manager_organizational_ability);

// int coincidence_with_the_project_manager_critical_thinking;

// if (critical_thinking >= project_manager_critical_thinking)
// {
//     coincidence_with_the_project_manager_critical_thinking = project_manager_critical_thinking;
// }
// else
// {
//     coincidence_with_the_project_manager_critical_thinking = critical_thinking;
// }

// Console.WriteLine("Совпадении в критерии - Критическое мышление " + coincidence_with_the_project_manager_critical_thinking);

// int coincidence_with_the_project_manager_multitasking;

// if (multitasking >= project_manager_multitasking)
// {
//     coincidence_with_the_project_manager_multitasking = project_manager_multitasking;
// }
// else
// {
//     coincidence_with_the_project_manager_multitasking = multitasking;
// }

// Console.WriteLine("Совпадении в критерии - Многозадачность " + coincidence_with_the_project_manager_multitasking);

// int coincidence_with_the_project_manager_creativity;

// if (creativity >= project_manager_creativity)
// {
//     coincidence_with_the_project_manager_creativity = project_manager_creativity;
// }
// else
// {
//     coincidence_with_the_project_manager_creativity = creativity;
// }

// Console.WriteLine("Совпадении в критерии - Креативность " + coincidence_with_the_project_manager_creativity);

// int coincidence_with_the_project_manager_stress_tolerance;

// if (stress_tolerance >= project_manager_stress_tolerance)
// {
//     coincidence_with_the_project_manager_stress_tolerance = project_manager_stress_tolerance;
// }
// else
// {
//     coincidence_with_the_project_manager_stress_tolerance = stress_tolerance;
// }

// Console.WriteLine("Совпадении в критерии - Стрессоустойчивость " + coincidence_with_the_project_manager_stress_tolerance);

// int coincidence_with_the_project_manager_time_control;

// if (time_control >= project_manager_time_control)
// {
//     coincidence_with_the_project_manager_time_control = project_manager_time_control;
// }
// else
// {
//     coincidence_with_the_project_manager_time_control = time_control;
// }

// Console.WriteLine("Совпадении в критерии - Контроль времени " + coincidence_with_the_project_manager_time_control);

// int coincidence_with_the_project_manager_work_with_a_large_amount_of_data;

// if (work_with_a_large_amount_of_data >= project_manager_work_with_a_large_amount_of_data)
// {
//     coincidence_with_the_project_manager_work_with_a_large_amount_of_data = project_manager_work_with_a_large_amount_of_data;
// }
// else
// {
//     coincidence_with_the_project_manager_work_with_a_large_amount_of_data = work_with_a_large_amount_of_data;
// }

// Console.WriteLine("Совпадении в критерии - Работа с большим объемом данных " + coincidence_with_the_project_manager_work_with_a_large_amount_of_data);

// int final_match_with_the_project_manager = coincidence_with_the_project_manager_extrovert +
// coincidence_with_the_project_manager_introvert +
// coincidence_with_the_project_manager_аbility_to_work_monotonously +
// coincidence_with_the_project_manager_мentoring +
// coincidence_with_the_project_manager_analytical_data +
// coincidence_with_the_project_manager_empathy +
// coincidence_with_the_project_manager_curiosity +
// coincidence_with_the_project_manager_oratory +
// coincidence_with_the_project_manager_organizational_ability +
// coincidence_with_the_project_manager_critical_thinking +
// coincidence_with_the_project_manager_multitasking +
// coincidence_with_the_project_manager_creativity +
// coincidence_with_the_project_manager_stress_tolerance +
// coincidence_with_the_project_manager_time_control +
// coincidence_with_the_project_manager_work_with_a_large_amount_of_data;

// double match_percentage_project_manager = ((double)final_match_with_the_project_manager)/project_manager_total_score*100;

// Console.WriteLine("Ваше совпадение " + final_match_with_the_project_manager + " из " + project_manager_total_score + " совпадение " + match_percentage_project_manager + "%");
// Console.WriteLine(" ");
// Console.WriteLine(" ");

// // сверка совадений с продакт-менеджер
// Console.WriteLine("Совпадения с продакт-менеджер");

// int coincidence_with_the_product_manager_extrovert;

// if (extrovert >= product_manager_extrovert)
// {
//     coincidence_with_the_product_manager_extrovert = product_manager_extrovert;
// }
// else
// {
//     coincidence_with_the_product_manager_extrovert = extrovert;
// }

// Console.WriteLine("Совпадении в критерии - экстраверт " + coincidence_with_the_product_manager_extrovert);

// int coincidence_with_the_product_manager_introvert;

// if (introvert >= product_manager_introvert)
// {
//     coincidence_with_the_product_manager_introvert = product_manager_introvert;
// }
// else
// {
//     coincidence_with_the_product_manager_introvert = introvert;
// }

// Console.WriteLine("Совпадении в критерии - интроверт " + coincidence_with_the_product_manager_introvert);

// int coincidence_with_the_product_manager_аbility_to_work_monotonously;

// if (аbility_to_work_monotonously >= product_manager_аbility_to_work_monotonously)
// {
//     coincidence_with_the_product_manager_аbility_to_work_monotonously = product_manager_аbility_to_work_monotonously;
// }
// else
// {
//     coincidence_with_the_product_manager_аbility_to_work_monotonously = аbility_to_work_monotonously;
// }

// Console.WriteLine("Совпадении в критерии - Способность к монотонной работе " + coincidence_with_the_product_manager_аbility_to_work_monotonously);

// int coincidence_with_the_product_manager_мentoring;

// if (мentoring >= product_manager_мentoring)
// {
//     coincidence_with_the_product_manager_мentoring = product_manager_мentoring;
// }
// else
// {
//     coincidence_with_the_product_manager_мentoring = мentoring;
// }

// Console.WriteLine("Совпадении в критерии - Наставничество " + coincidence_with_the_product_manager_мentoring);

// int coincidence_with_the_product_manager_analytical_data;

// if (analytical_data >= product_manager_analytical_data)
// {
//     coincidence_with_the_product_manager_analytical_data = product_manager_analytical_data;
// }
// else
// {
//     coincidence_with_the_product_manager_analytical_data = analytical_data;
// }

// Console.WriteLine("Совпадении в критерии - Аналитические навыки " + coincidence_with_the_product_manager_analytical_data);

// int coincidence_with_the_product_manager_empathy;

// if (empathy >= product_manager_empathy)
// {
//     coincidence_with_the_product_manager_empathy = product_manager_empathy;
// }
// else
// {
//     coincidence_with_the_product_manager_empathy = empathy;
// }

// Console.WriteLine("Совпадении в критерии - Эмпатия " + coincidence_with_the_product_manager_empathy);

// int coincidence_with_the_product_manager_curiosity;

// if (curiosity >= product_manager_curiosity)
// {
//     coincidence_with_the_product_manager_curiosity = product_manager_curiosity;
// }
// else
// {
//     coincidence_with_the_product_manager_curiosity = curiosity;
// }

// Console.WriteLine("Совпадении в критерии - Любопытство " + coincidence_with_the_product_manager_curiosity);

// int coincidence_with_the_product_manager_oratory;

// if (oratory >= product_manager_oratory)
// {
//     coincidence_with_the_product_manager_oratory = product_manager_oratory;
// }
// else
// {
//     coincidence_with_the_product_manager_oratory = oratory;
// }

// Console.WriteLine("Совпадении в критерии - Ораточрское искусство " + coincidence_with_the_product_manager_oratory);

// int coincidence_with_the_product_manager_organizational_ability;

// if (organizational_ability >= product_manager_organizational_ability)
// {
//     coincidence_with_the_product_manager_organizational_ability = product_manager_organizational_ability;
// }
// else
// {
//     coincidence_with_the_product_manager_organizational_ability = organizational_ability;
// }

// Console.WriteLine("Совпадении в критерии - Организаторские способности " + coincidence_with_the_product_manager_organizational_ability);

// int coincidence_with_the_product_manager_critical_thinking;

// if (critical_thinking >= product_manager_critical_thinking)
// {
//     coincidence_with_the_product_manager_critical_thinking = product_manager_critical_thinking;
// }
// else
// {
//     coincidence_with_the_product_manager_critical_thinking = critical_thinking;
// }

// Console.WriteLine("Совпадении в критерии - Критическое мышление " + coincidence_with_the_product_manager_critical_thinking);

// int coincidence_with_the_product_manager_multitasking;

// if (multitasking >= product_manager_multitasking)
// {
//     coincidence_with_the_product_manager_multitasking = product_manager_multitasking;
// }
// else
// {
//     coincidence_with_the_product_manager_multitasking = multitasking;
// }

// Console.WriteLine("Совпадении в критерии - Многозадачность " + coincidence_with_the_product_manager_multitasking);

// int coincidence_with_the_product_manager_creativity;

// if (creativity >= product_manager_creativity)
// {
//     coincidence_with_the_product_manager_creativity = product_manager_creativity;
// }
// else
// {
//     coincidence_with_the_product_manager_creativity = creativity;
// }

// Console.WriteLine("Совпадении в критерии - Креативность " + coincidence_with_the_product_manager_creativity);

// int coincidence_with_the_product_manager_stress_tolerance;

// if (stress_tolerance >= product_manager_stress_tolerance)
// {
//     coincidence_with_the_product_manager_stress_tolerance = product_manager_stress_tolerance;
// }
// else
// {
//     coincidence_with_the_product_manager_stress_tolerance = stress_tolerance;
// }

// Console.WriteLine("Совпадении в критерии - Стрессоустойчивость " + coincidence_with_the_product_manager_stress_tolerance);

// int coincidence_with_the_product_manager_time_control;

// if (time_control >= product_manager_time_control)
// {
//     coincidence_with_the_product_manager_time_control = product_manager_time_control;
// }
// else
// {
//     coincidence_with_the_product_manager_time_control = time_control;
// }

// Console.WriteLine("Совпадении в критерии - Контроль времени " + coincidence_with_the_product_manager_time_control);

// int coincidence_with_the_product_manager_work_with_a_large_amount_of_data;

// if (work_with_a_large_amount_of_data >= product_manager_work_with_a_large_amount_of_data)
// {
//     coincidence_with_the_product_manager_work_with_a_large_amount_of_data = product_manager_work_with_a_large_amount_of_data;
// }
// else
// {
//     coincidence_with_the_product_manager_work_with_a_large_amount_of_data = work_with_a_large_amount_of_data;
// }

// Console.WriteLine("Совпадении в критерии - Работа с большим объемом данных " + coincidence_with_the_product_manager_work_with_a_large_amount_of_data);

// int final_match_with_the_product_manager = coincidence_with_the_product_manager_extrovert +
// coincidence_with_the_product_manager_introvert +
// coincidence_with_the_product_manager_аbility_to_work_monotonously +
// coincidence_with_the_product_manager_мentoring +
// coincidence_with_the_product_manager_analytical_data +
// coincidence_with_the_product_manager_empathy +
// coincidence_with_the_product_manager_curiosity +
// coincidence_with_the_product_manager_oratory +
// coincidence_with_the_product_manager_organizational_ability +
// coincidence_with_the_product_manager_critical_thinking +
// coincidence_with_the_product_manager_multitasking +
// coincidence_with_the_product_manager_creativity +
// coincidence_with_the_product_manager_stress_tolerance +
// coincidence_with_the_product_manager_time_control +
// coincidence_with_the_product_manager_work_with_a_large_amount_of_data;

// double match_percentage_product_manager = ((double)final_match_with_the_product_manager)/product_manager_total_score*100;

// Console.WriteLine("Ваше совпадение " + final_match_with_the_product_manager + " из " + product_manager_total_score + " совпадение " + match_percentage_project_manager + "%");
// Console.WriteLine(" ");
// Console.WriteLine(" ");
