﻿// Портрет специальности программист
int programmer_extrovert = 2;
int programmer_introvert = 3;
int programmer_аbility_to_work_monotonously = 4;
int programmer_мentoring = 0;
int programmer_analytical_data = 4;
int programmer_empathy = 2;
int programmer_curiosity = 5; 
int programmer_oratory = 0;
int programmer_organizational_ability = 1;
int programmer_critical_thinking = 3;
int programmer_multitasking = 3;
int programmer_creativity = 1;
int programmer_stress_tolerance = 4;
int programmer_time_control = 3;
int programmer_work_with_a_large_amount_of_data = 5;
int programmer_total_score = 40;

// Портрет специальности тестировщик
int tester_extrovert = 2;
int tester_introvert = 2;
int tester_аbility_to_work_monotonously = 5;
int tester_мentoring = 0;
int tester_analytical_data = 3;
int tester_empathy = 3;
int tester_curiosity = 4; 
int tester_oratory = 0;
int tester_organizational_ability = 1;
int tester_critical_thinking = 3;
int tester_multitasking = 3;
int tester_creativity = 1;
int tester_stress_tolerance = 2;
int tester_time_control = 3;
int tester_work_with_a_large_amount_of_data = 3;
int tester_total_score = 35;

// Портрет специальности аналитика
int analytics_extrovert = 3;
int analytics_introvert = 4;
int analytics_аbility_to_work_monotonously = 3;
int analytics_мentoring = 0;
int analytics_analytical_data = 5;
int analytics_empathy = 2;
int analytics_curiosity = 4; 
int analytics_oratory = 1;
int analytics_organizational_ability = 2;
int analytics_critical_thinking = 5;
int analytics_multitasking = 3;
int analytics_creativity = 3;
int analytics_stress_tolerance = 3;
int analytics_time_control = 2;
int analytics_work_with_a_large_amount_of_data = 4;
int analytics_total_score = 44;

// Портрет специальности Проджект-менеджер
int project_manager_extrovert = 4;
int project_manager_introvert = 1;
int project_manager_аbility_to_work_monotonously = 1;
int project_manager_мentoring = 3;
int project_manager_analytical_data = 3;
int project_manager_empathy = 4;
int project_manager_curiosity = 3; 
int project_manager_oratory = 4;
int project_manager_organizational_ability = 5;
int project_manager_critical_thinking = 3;
int project_manager_multitasking = 5;
int project_manager_creativity = 3;
int project_manager_stress_tolerance = 5;
int project_manager_time_control = 5;
int project_manager_work_with_a_large_amount_of_data = 4;
int project_manager_total_score = 53;

// Портрет специальности Продакт-менеджер
int product_manager_extrovert = 3;
int product_manager_introvert = 2;
int product_manager_аbility_to_work_monotonously = 3;
int product_manager_мentoring = 3;
int product_manager_analytical_data = 3;
int product_manager_empathy = 4;
int product_manager_curiosity = 2; 
int product_manager_oratory = 4;
int product_manager_organizational_ability = 4;
int product_manager_critical_thinking = 3;
int product_manager_multitasking = 5;
int product_manager_creativity = 2;
int product_manager_stress_tolerance = 4;
int product_manager_time_control = 4;
int product_manager_work_with_a_large_amount_of_data = 3;
int product_manager_total_score = 49;

Console.WriteLine("1. Введите свой балл критерия - Экстраверт");
int extrovert = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("2. Введите свой балл критерия - Интроверт");
int introvert = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("3. Введите свой балл критерия - Способность к монотонной работе");
int аbility_to_work_monotonously = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("4. Введите свой балл критерия - Наставничество");
int мentoring = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("5. Введите свой балл критерия - Аналитические навыки");
int analytical_data = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("6. Введите свой балл критерия - Эмпатия");
int empathy = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("7. Введите свой балл критерия - Любопытство");
int curiosity = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("8. Введите свой балл критерия - Ораточрское искусство");
int oratory = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("9. Введите свой балл критерия - Организаторские способности");
int organizational_ability = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("10. Введите свой балл критерия - Критическое мышление");
int critical_thinking = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("11. Введите свой балл критерия - Многозадачность");
int multitasking = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("12. Введите свой балл критерия - Креативность");
int creativity = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("13. Введите свой балл критерия - Стрессоустойчивость");
int stress_tolerance = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("14. Введите свой балл критерия - Контроль времени");
int time_control = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("15. Введите свой балл критерия - Работа с большим объемом данных");
int work_with_a_large_amount_of_data = Convert.ToInt32(Console.ReadLine());

// // посчет баллов для проверки
// int your_total_score = extrovert + introvert + аbility_to_work_monotonously + мentoring + analytical_data + empathy + curiosity + oratory + organizational_ability + critical_thinking + multitasking + creativity + stress_tolerance + time_control + work_with_a_large_amount_of_data;
// Console.WriteLine(your_total_score);

// сверка совадений с программистом
Console.WriteLine("Совпадения с программистом");

int coincidence_with_the_programmer_extrovert;

if (extrovert >= programmer_extrovert)
{
    coincidence_with_the_programmer_extrovert = programmer_extrovert;
}
else
{
    coincidence_with_the_programmer_extrovert = extrovert;
}

Console.WriteLine("Совпадении в критерии - экстраверт " + coincidence_with_the_programmer_extrovert);

int coincidence_with_the_programmer_introvert;

if (introvert >= programmer_introvert)
{
    coincidence_with_the_programmer_introvert = programmer_introvert;
}
else
{
    coincidence_with_the_programmer_introvert = introvert;
}

Console.WriteLine("Совпадении в критерии - интроверт " + coincidence_with_the_programmer_introvert);

int coincidence_with_the_programmer_аbility_to_work_monotonously;

if (аbility_to_work_monotonously >= programmer_аbility_to_work_monotonously)
{
    coincidence_with_the_programmer_аbility_to_work_monotonously = programmer_аbility_to_work_monotonously;
}
else
{
    coincidence_with_the_programmer_аbility_to_work_monotonously = аbility_to_work_monotonously;
}

Console.WriteLine("Совпадении в критерии - Способность к монотонной работе " + coincidence_with_the_programmer_аbility_to_work_monotonously);

int coincidence_with_the_programmer_мentoring;

if (мentoring >= programmer_мentoring)
{
    coincidence_with_the_programmer_мentoring = programmer_мentoring;
}
else
{
    coincidence_with_the_programmer_мentoring = мentoring;
}

Console.WriteLine("Совпадении в критерии - Наставничество " + coincidence_with_the_programmer_мentoring);

int coincidence_with_the_programmer_analytical_data;

if (analytical_data >= programmer_analytical_data)
{
    coincidence_with_the_programmer_analytical_data = programmer_analytical_data;
}
else
{
    coincidence_with_the_programmer_analytical_data = analytical_data;
}

Console.WriteLine("Совпадении в критерии - Аналитические навыки " + coincidence_with_the_programmer_analytical_data);

int coincidence_with_the_programmer_empathy;

if (empathy >= programmer_empathy)
{
    coincidence_with_the_programmer_empathy = programmer_empathy;
}
else
{
    coincidence_with_the_programmer_empathy = empathy;
}

Console.WriteLine("Совпадении в критерии - Эмпатия " + coincidence_with_the_programmer_empathy);

int coincidence_with_the_programmer_curiosity;

if (curiosity >= programmer_curiosity)
{
    coincidence_with_the_programmer_curiosity = programmer_curiosity;
}
else
{
    coincidence_with_the_programmer_curiosity = curiosity;
}

Console.WriteLine("Совпадении в критерии - Любопытство " + coincidence_with_the_programmer_curiosity);

int coincidence_with_the_programmer_oratory;

if (oratory >= programmer_oratory)
{
    coincidence_with_the_programmer_oratory = programmer_oratory;
}
else
{
    coincidence_with_the_programmer_oratory = oratory;
}

Console.WriteLine("Совпадении в критерии - Ораточрское искусство " + coincidence_with_the_programmer_oratory);

int coincidence_with_the_programmer_organizational_ability;

if (organizational_ability >= programmer_organizational_ability)
{
    coincidence_with_the_programmer_organizational_ability = programmer_organizational_ability;
}
else
{
    coincidence_with_the_programmer_organizational_ability = organizational_ability;
}

Console.WriteLine("Совпадении в критерии - Организаторские способности " + coincidence_with_the_programmer_organizational_ability);

int coincidence_with_the_programmer_critical_thinking;

if (critical_thinking >= programmer_critical_thinking)
{
    coincidence_with_the_programmer_critical_thinking = programmer_critical_thinking;
}
else
{
    coincidence_with_the_programmer_critical_thinking = critical_thinking;
}

Console.WriteLine("Совпадении в критерии - Критическое мышление " + coincidence_with_the_programmer_critical_thinking);

int coincidence_with_the_programmer_multitasking;

if (multitasking >= programmer_multitasking)
{
    coincidence_with_the_programmer_multitasking = programmer_multitasking;
}
else
{
    coincidence_with_the_programmer_multitasking = multitasking;
}

Console.WriteLine("Совпадении в критерии - Многозадачность " + coincidence_with_the_programmer_multitasking);

int coincidence_with_the_programmer_creativity;

if (creativity >= programmer_creativity)
{
    coincidence_with_the_programmer_creativity = programmer_creativity;
}
else
{
    coincidence_with_the_programmer_creativity = creativity;
}

Console.WriteLine("Совпадении в критерии - Креативность " + coincidence_with_the_programmer_creativity);

int coincidence_with_the_programmer_stress_tolerance;

if (stress_tolerance >= programmer_stress_tolerance)
{
    coincidence_with_the_programmer_stress_tolerance = programmer_stress_tolerance;
}
else
{
    coincidence_with_the_programmer_stress_tolerance = stress_tolerance;
}

Console.WriteLine("Совпадении в критерии - Стрессоустойчивость " + coincidence_with_the_programmer_stress_tolerance);

int coincidence_with_the_programmer_time_control;

if (time_control >= programmer_time_control)
{
    coincidence_with_the_programmer_time_control = programmer_time_control;
}
else
{
    coincidence_with_the_programmer_time_control = time_control;
}

Console.WriteLine("Совпадении в критерии - Контроль времени " + coincidence_with_the_programmer_time_control);

int coincidence_with_the_programmer_work_with_a_large_amount_of_data;

if (work_with_a_large_amount_of_data >= programmer_work_with_a_large_amount_of_data)
{
    coincidence_with_the_programmer_work_with_a_large_amount_of_data = programmer_work_with_a_large_amount_of_data;
}
else
{
    coincidence_with_the_programmer_work_with_a_large_amount_of_data = work_with_a_large_amount_of_data;
}

Console.WriteLine("Совпадении в критерии - Работа с большим объемом данных " + coincidence_with_the_programmer_work_with_a_large_amount_of_data);

int final_match_with_the_programmer = coincidence_with_the_programmer_extrovert +
coincidence_with_the_programmer_introvert +
coincidence_with_the_programmer_аbility_to_work_monotonously +
coincidence_with_the_programmer_мentoring +
coincidence_with_the_programmer_analytical_data +
coincidence_with_the_programmer_empathy +
coincidence_with_the_programmer_curiosity +
coincidence_with_the_programmer_oratory +
coincidence_with_the_programmer_organizational_ability +
coincidence_with_the_programmer_critical_thinking +
coincidence_with_the_programmer_multitasking +
coincidence_with_the_programmer_creativity +
coincidence_with_the_programmer_stress_tolerance +
coincidence_with_the_programmer_time_control +
coincidence_with_the_programmer_work_with_a_large_amount_of_data;

double match_percentage_programmer = ((double)final_match_with_the_programmer)/programmer_total_score*100;

Console.WriteLine("Ваше совпадение " + final_match_with_the_programmer + " из " + programmer_total_score + " совпадение " + match_percentage_programmer + "%");
Console.WriteLine(" ");
Console.WriteLine(" ");

// сверка совадений с тестировщиком
Console.WriteLine("Совпадения с тестировщиком");

int coincidence_with_the_tester_extrovert;

if (extrovert >= tester_extrovert)
{
    coincidence_with_the_tester_extrovert = tester_extrovert;
}
else
{
    coincidence_with_the_tester_extrovert = extrovert;
}

Console.WriteLine("Совпадении в критерии - экстраверт " + coincidence_with_the_tester_extrovert);

int coincidence_with_the_tester_introvert;

if (introvert >= tester_introvert)
{
    coincidence_with_the_tester_introvert = tester_introvert;
}
else
{
    coincidence_with_the_tester_introvert = introvert;
}

Console.WriteLine("Совпадении в критерии - интроверт " + coincidence_with_the_tester_introvert);

int coincidence_with_the_tester_аbility_to_work_monotonously;

if (аbility_to_work_monotonously >= tester_аbility_to_work_monotonously)
{
    coincidence_with_the_tester_аbility_to_work_monotonously = tester_аbility_to_work_monotonously;
}
else
{
    coincidence_with_the_tester_аbility_to_work_monotonously = аbility_to_work_monotonously;
}

Console.WriteLine("Совпадении в критерии - Способность к монотонной работе " + coincidence_with_the_tester_аbility_to_work_monotonously);

int coincidence_with_the_tester_мentoring;

if (мentoring >= tester_мentoring)
{
    coincidence_with_the_tester_мentoring = tester_мentoring;
}
else
{
    coincidence_with_the_tester_мentoring = мentoring;
}

Console.WriteLine("Совпадении в критерии - Наставничество " + coincidence_with_the_tester_мentoring);

int coincidence_with_the_tester_analytical_data;

if (analytical_data >= tester_analytical_data)
{
    coincidence_with_the_tester_analytical_data = tester_analytical_data;
}
else
{
    coincidence_with_the_tester_analytical_data = analytical_data;
}

Console.WriteLine("Совпадении в критерии - Аналитические навыки " + coincidence_with_the_tester_analytical_data);

int coincidence_with_the_tester_empathy;

if (empathy >= tester_empathy)
{
    coincidence_with_the_tester_empathy = tester_empathy;
}
else
{
    coincidence_with_the_tester_empathy = empathy;
}

Console.WriteLine("Совпадении в критерии - Эмпатия " + coincidence_with_the_tester_empathy);

int coincidence_with_the_tester_curiosity;

if (curiosity >= tester_curiosity)
{
    coincidence_with_the_tester_curiosity = tester_curiosity;
}
else
{
    coincidence_with_the_tester_curiosity = curiosity;
}

Console.WriteLine("Совпадении в критерии - Любопытство " + coincidence_with_the_tester_curiosity);

int coincidence_with_the_tester_oratory;

if (oratory >= tester_oratory)
{
    coincidence_with_the_tester_oratory = tester_oratory;
}
else
{
    coincidence_with_the_tester_oratory = oratory;
}

Console.WriteLine("Совпадении в критерии - Ораточрское искусство " + coincidence_with_the_tester_oratory);

int coincidence_with_the_tester_organizational_ability;

if (organizational_ability >= tester_organizational_ability)
{
    coincidence_with_the_tester_organizational_ability = tester_organizational_ability;
}
else
{
    coincidence_with_the_tester_organizational_ability = organizational_ability;
}

Console.WriteLine("Совпадении в критерии - Организаторские способности " + coincidence_with_the_tester_organizational_ability);

int coincidence_with_the_tester_critical_thinking;

if (critical_thinking >= tester_critical_thinking)
{
    coincidence_with_the_tester_critical_thinking = tester_critical_thinking;
}
else
{
    coincidence_with_the_tester_critical_thinking = critical_thinking;
}

Console.WriteLine("Совпадении в критерии - Критическое мышление " + coincidence_with_the_tester_critical_thinking);

int coincidence_with_the_tester_multitasking;

if (multitasking >= tester_multitasking)
{
    coincidence_with_the_tester_multitasking = tester_multitasking;
}
else
{
    coincidence_with_the_tester_multitasking = multitasking;
}

Console.WriteLine("Совпадении в критерии - Многозадачность " + coincidence_with_the_tester_multitasking);

int coincidence_with_the_tester_creativity;

if (creativity >= tester_creativity)
{
    coincidence_with_the_tester_creativity = tester_creativity;
}
else
{
    coincidence_with_the_tester_creativity = creativity;
}

Console.WriteLine("Совпадении в критерии - Креативность " + coincidence_with_the_tester_creativity);

int coincidence_with_the_tester_stress_tolerance;

if (stress_tolerance >= tester_stress_tolerance)
{
    coincidence_with_the_tester_stress_tolerance = tester_stress_tolerance;
}
else
{
    coincidence_with_the_tester_stress_tolerance = stress_tolerance;
}

Console.WriteLine("Совпадении в критерии - Стрессоустойчивость " + coincidence_with_the_tester_stress_tolerance);

int coincidence_with_the_tester_time_control;

if (time_control >= tester_time_control)
{
    coincidence_with_the_tester_time_control = tester_time_control;
}
else
{
    coincidence_with_the_tester_time_control = time_control;
}

Console.WriteLine("Совпадении в критерии - Контроль времени " + coincidence_with_the_tester_time_control);

int coincidence_with_the_tester_work_with_a_large_amount_of_data;

if (work_with_a_large_amount_of_data >= tester_work_with_a_large_amount_of_data)
{
    coincidence_with_the_tester_work_with_a_large_amount_of_data = tester_work_with_a_large_amount_of_data;
}
else
{
    coincidence_with_the_tester_work_with_a_large_amount_of_data = work_with_a_large_amount_of_data;
}

Console.WriteLine("Совпадении в критерии - Работа с большим объемом данных " + coincidence_with_the_tester_work_with_a_large_amount_of_data);

int final_match_with_the_tester = coincidence_with_the_tester_extrovert +
coincidence_with_the_tester_introvert +
coincidence_with_the_tester_аbility_to_work_monotonously +
coincidence_with_the_tester_мentoring +
coincidence_with_the_tester_analytical_data +
coincidence_with_the_tester_empathy +
coincidence_with_the_tester_curiosity +
coincidence_with_the_tester_oratory +
coincidence_with_the_tester_organizational_ability +
coincidence_with_the_tester_critical_thinking +
coincidence_with_the_tester_multitasking +
coincidence_with_the_tester_creativity +
coincidence_with_the_tester_stress_tolerance +
coincidence_with_the_tester_time_control +
coincidence_with_the_tester_work_with_a_large_amount_of_data;

double match_percentage_tester = ((double)final_match_with_the_tester)/tester_total_score*100;

Console.WriteLine("Ваше совпадение " + final_match_with_the_tester + " из " + tester_total_score + " совпадение " + match_percentage_tester + "%");
Console.WriteLine(" ");
Console.WriteLine(" ");

// сверка совадений с аналитиком
Console.WriteLine("Совпадения с аналитиком");

int coincidence_with_the_analytics_extrovert;

if (extrovert >= analytics_extrovert)
{
    coincidence_with_the_analytics_extrovert = analytics_extrovert;
}
else
{
    coincidence_with_the_analytics_extrovert = extrovert;
}

Console.WriteLine("Совпадении в критерии - экстраверт " + coincidence_with_the_analytics_extrovert);

int coincidence_with_the_analytics_introvert;

if (introvert >= analytics_introvert)
{
    coincidence_with_the_analytics_introvert = analytics_introvert;
}
else
{
    coincidence_with_the_analytics_introvert = introvert;
}

Console.WriteLine("Совпадении в критерии - интроверт " + coincidence_with_the_analytics_introvert);

int coincidence_with_the_analytics_аbility_to_work_monotonously;

if (аbility_to_work_monotonously >= analytics_аbility_to_work_monotonously)
{
    coincidence_with_the_analytics_аbility_to_work_monotonously = analytics_аbility_to_work_monotonously;
}
else
{
    coincidence_with_the_analytics_аbility_to_work_monotonously = аbility_to_work_monotonously;
}

Console.WriteLine("Совпадении в критерии - Способность к монотонной работе " + coincidence_with_the_analytics_аbility_to_work_monotonously);

int coincidence_with_the_analytics_мentoring;

if (мentoring >= analytics_мentoring)
{
    coincidence_with_the_analytics_мentoring = analytics_мentoring;
}
else
{
    coincidence_with_the_analytics_мentoring = мentoring;
}

Console.WriteLine("Совпадении в критерии - Наставничество " + coincidence_with_the_analytics_мentoring);

int coincidence_with_the_analytics_analytical_data;

if (analytical_data >= analytics_analytical_data)
{
    coincidence_with_the_analytics_analytical_data = analytics_analytical_data;
}
else
{
    coincidence_with_the_analytics_analytical_data = analytical_data;
}

Console.WriteLine("Совпадении в критерии - Аналитические навыки " + coincidence_with_the_analytics_analytical_data);

int coincidence_with_the_analytics_empathy;

if (empathy >= analytics_empathy)
{
    coincidence_with_the_analytics_empathy = analytics_empathy;
}
else
{
    coincidence_with_the_analytics_empathy = empathy;
}

Console.WriteLine("Совпадении в критерии - Эмпатия " + coincidence_with_the_analytics_empathy);

int coincidence_with_the_analytics_curiosity;

if (curiosity >= analytics_curiosity)
{
    coincidence_with_the_analytics_curiosity = analytics_curiosity;
}
else
{
    coincidence_with_the_analytics_curiosity = curiosity;
}

Console.WriteLine("Совпадении в критерии - Любопытство " + coincidence_with_the_analytics_curiosity);

int coincidence_with_the_analytics_oratory;

if (oratory >= analytics_oratory)
{
    coincidence_with_the_analytics_oratory = analytics_oratory;
}
else
{
    coincidence_with_the_analytics_oratory = oratory;
}

Console.WriteLine("Совпадении в критерии - Ораточрское искусство " + coincidence_with_the_analytics_oratory);

int coincidence_with_the_analytics_organizational_ability;

if (organizational_ability >= analytics_organizational_ability)
{
    coincidence_with_the_analytics_organizational_ability = analytics_organizational_ability;
}
else
{
    coincidence_with_the_analytics_organizational_ability = organizational_ability;
}

Console.WriteLine("Совпадении в критерии - Организаторские способности " + coincidence_with_the_analytics_organizational_ability);

int coincidence_with_the_analytics_critical_thinking;

if (critical_thinking >= analytics_critical_thinking)
{
    coincidence_with_the_analytics_critical_thinking = analytics_critical_thinking;
}
else
{
    coincidence_with_the_analytics_critical_thinking = critical_thinking;
}

Console.WriteLine("Совпадении в критерии - Критическое мышление " + coincidence_with_the_analytics_critical_thinking);

int coincidence_with_the_analytics_multitasking;

if (multitasking >= analytics_multitasking)
{
    coincidence_with_the_analytics_multitasking = analytics_multitasking;
}
else
{
    coincidence_with_the_analytics_multitasking = multitasking;
}

Console.WriteLine("Совпадении в критерии - Многозадачность " + coincidence_with_the_analytics_multitasking);

int coincidence_with_the_analytics_creativity;

if (creativity >= analytics_creativity)
{
    coincidence_with_the_analytics_creativity = analytics_creativity;
}
else
{
    coincidence_with_the_analytics_creativity = creativity;
}

Console.WriteLine("Совпадении в критерии - Креативность " + coincidence_with_the_analytics_creativity);

int coincidence_with_the_analytics_stress_tolerance;

if (stress_tolerance >= analytics_stress_tolerance)
{
    coincidence_with_the_analytics_stress_tolerance = analytics_stress_tolerance;
}
else
{
    coincidence_with_the_analytics_stress_tolerance = stress_tolerance;
}

Console.WriteLine("Совпадении в критерии - Стрессоустойчивость " + coincidence_with_the_analytics_stress_tolerance);

int coincidence_with_the_analytics_time_control;

if (time_control >= analytics_time_control)
{
    coincidence_with_the_analytics_time_control = analytics_time_control;
}
else
{
    coincidence_with_the_analytics_time_control = time_control;
}

Console.WriteLine("Совпадении в критерии - Контроль времени " + coincidence_with_the_analytics_time_control);

int coincidence_with_the_analytics_work_with_a_large_amount_of_data;

if (work_with_a_large_amount_of_data >= analytics_work_with_a_large_amount_of_data)
{
    coincidence_with_the_analytics_work_with_a_large_amount_of_data = analytics_work_with_a_large_amount_of_data;
}
else
{
    coincidence_with_the_analytics_work_with_a_large_amount_of_data = work_with_a_large_amount_of_data;
}

Console.WriteLine("Совпадении в критерии - Работа с большим объемом данных " + coincidence_with_the_analytics_work_with_a_large_amount_of_data);

int final_match_with_the_analytics = coincidence_with_the_analytics_extrovert +
coincidence_with_the_analytics_introvert +
coincidence_with_the_analytics_аbility_to_work_monotonously +
coincidence_with_the_analytics_мentoring +
coincidence_with_the_analytics_analytical_data +
coincidence_with_the_analytics_empathy +
coincidence_with_the_analytics_curiosity +
coincidence_with_the_analytics_oratory +
coincidence_with_the_analytics_organizational_ability +
coincidence_with_the_analytics_critical_thinking +
coincidence_with_the_analytics_multitasking +
coincidence_with_the_analytics_creativity +
coincidence_with_the_analytics_stress_tolerance +
coincidence_with_the_analytics_time_control +
coincidence_with_the_analytics_work_with_a_large_amount_of_data;

double match_percentage_analytics = ((double)final_match_with_the_analytics)/analytics_total_score*100;

Console.WriteLine("Ваше совпадение " + final_match_with_the_analytics + " из " + analytics_total_score + " совпадение " + match_percentage_analytics + "%");
Console.WriteLine(" ");
Console.WriteLine(" ");

// сверка совадений с проджект-менеджер
Console.WriteLine("Совпадения с проджект-менеджер");

int coincidence_with_the_project_manager_extrovert;

if (extrovert >= project_manager_extrovert)
{
    coincidence_with_the_project_manager_extrovert = project_manager_extrovert;
}
else
{
    coincidence_with_the_project_manager_extrovert = extrovert;
}

Console.WriteLine("Совпадении в критерии - экстраверт " + coincidence_with_the_project_manager_extrovert);

int coincidence_with_the_project_manager_introvert;

if (introvert >= project_manager_introvert)
{
    coincidence_with_the_project_manager_introvert = project_manager_introvert;
}
else
{
    coincidence_with_the_project_manager_introvert = introvert;
}

Console.WriteLine("Совпадении в критерии - интроверт " + coincidence_with_the_project_manager_introvert);

int coincidence_with_the_project_manager_аbility_to_work_monotonously;

if (аbility_to_work_monotonously >= project_manager_аbility_to_work_monotonously)
{
    coincidence_with_the_project_manager_аbility_to_work_monotonously = project_manager_аbility_to_work_monotonously;
}
else
{
    coincidence_with_the_project_manager_аbility_to_work_monotonously = аbility_to_work_monotonously;
}

Console.WriteLine("Совпадении в критерии - Способность к монотонной работе " + coincidence_with_the_project_manager_аbility_to_work_monotonously);

int coincidence_with_the_project_manager_мentoring;

if (мentoring >= project_manager_мentoring)
{
    coincidence_with_the_project_manager_мentoring = project_manager_мentoring;
}
else
{
    coincidence_with_the_project_manager_мentoring = мentoring;
}

Console.WriteLine("Совпадении в критерии - Наставничество " + coincidence_with_the_project_manager_мentoring);

int coincidence_with_the_project_manager_analytical_data;

if (analytical_data >= project_manager_analytical_data)
{
    coincidence_with_the_project_manager_analytical_data = project_manager_analytical_data;
}
else
{
    coincidence_with_the_project_manager_analytical_data = analytical_data;
}

Console.WriteLine("Совпадении в критерии - Аналитические навыки " + coincidence_with_the_project_manager_analytical_data);

int coincidence_with_the_project_manager_empathy;

if (empathy >= project_manager_empathy)
{
    coincidence_with_the_project_manager_empathy = project_manager_empathy;
}
else
{
    coincidence_with_the_project_manager_empathy = empathy;
}

Console.WriteLine("Совпадении в критерии - Эмпатия " + coincidence_with_the_project_manager_empathy);

int coincidence_with_the_project_manager_curiosity;

if (curiosity >= project_manager_curiosity)
{
    coincidence_with_the_project_manager_curiosity = project_manager_curiosity;
}
else
{
    coincidence_with_the_project_manager_curiosity = curiosity;
}

Console.WriteLine("Совпадении в критерии - Любопытство " + coincidence_with_the_project_manager_curiosity);

int coincidence_with_the_project_manager_oratory;

if (oratory >= project_manager_oratory)
{
    coincidence_with_the_project_manager_oratory = project_manager_oratory;
}
else
{
    coincidence_with_the_project_manager_oratory = oratory;
}

Console.WriteLine("Совпадении в критерии - Ораточрское искусство " + coincidence_with_the_project_manager_oratory);

int coincidence_with_the_project_manager_organizational_ability;

if (organizational_ability >= project_manager_organizational_ability)
{
    coincidence_with_the_project_manager_organizational_ability = project_manager_organizational_ability;
}
else
{
    coincidence_with_the_project_manager_organizational_ability = organizational_ability;
}

Console.WriteLine("Совпадении в критерии - Организаторские способности " + coincidence_with_the_project_manager_organizational_ability);

int coincidence_with_the_project_manager_critical_thinking;

if (critical_thinking >= project_manager_critical_thinking)
{
    coincidence_with_the_project_manager_critical_thinking = project_manager_critical_thinking;
}
else
{
    coincidence_with_the_project_manager_critical_thinking = critical_thinking;
}

Console.WriteLine("Совпадении в критерии - Критическое мышление " + coincidence_with_the_project_manager_critical_thinking);

int coincidence_with_the_project_manager_multitasking;

if (multitasking >= project_manager_multitasking)
{
    coincidence_with_the_project_manager_multitasking = project_manager_multitasking;
}
else
{
    coincidence_with_the_project_manager_multitasking = multitasking;
}

Console.WriteLine("Совпадении в критерии - Многозадачность " + coincidence_with_the_project_manager_multitasking);

int coincidence_with_the_project_manager_creativity;

if (creativity >= project_manager_creativity)
{
    coincidence_with_the_project_manager_creativity = project_manager_creativity;
}
else
{
    coincidence_with_the_project_manager_creativity = creativity;
}

Console.WriteLine("Совпадении в критерии - Креативность " + coincidence_with_the_project_manager_creativity);

int coincidence_with_the_project_manager_stress_tolerance;

if (stress_tolerance >= project_manager_stress_tolerance)
{
    coincidence_with_the_project_manager_stress_tolerance = project_manager_stress_tolerance;
}
else
{
    coincidence_with_the_project_manager_stress_tolerance = stress_tolerance;
}

Console.WriteLine("Совпадении в критерии - Стрессоустойчивость " + coincidence_with_the_project_manager_stress_tolerance);

int coincidence_with_the_project_manager_time_control;

if (time_control >= project_manager_time_control)
{
    coincidence_with_the_project_manager_time_control = project_manager_time_control;
}
else
{
    coincidence_with_the_project_manager_time_control = time_control;
}

Console.WriteLine("Совпадении в критерии - Контроль времени " + coincidence_with_the_project_manager_time_control);

int coincidence_with_the_project_manager_work_with_a_large_amount_of_data;

if (work_with_a_large_amount_of_data >= project_manager_work_with_a_large_amount_of_data)
{
    coincidence_with_the_project_manager_work_with_a_large_amount_of_data = project_manager_work_with_a_large_amount_of_data;
}
else
{
    coincidence_with_the_project_manager_work_with_a_large_amount_of_data = work_with_a_large_amount_of_data;
}

Console.WriteLine("Совпадении в критерии - Работа с большим объемом данных " + coincidence_with_the_project_manager_work_with_a_large_amount_of_data);

int final_match_with_the_project_manager = coincidence_with_the_project_manager_extrovert +
coincidence_with_the_project_manager_introvert +
coincidence_with_the_project_manager_аbility_to_work_monotonously +
coincidence_with_the_project_manager_мentoring +
coincidence_with_the_project_manager_analytical_data +
coincidence_with_the_project_manager_empathy +
coincidence_with_the_project_manager_curiosity +
coincidence_with_the_project_manager_oratory +
coincidence_with_the_project_manager_organizational_ability +
coincidence_with_the_project_manager_critical_thinking +
coincidence_with_the_project_manager_multitasking +
coincidence_with_the_project_manager_creativity +
coincidence_with_the_project_manager_stress_tolerance +
coincidence_with_the_project_manager_time_control +
coincidence_with_the_project_manager_work_with_a_large_amount_of_data;

double match_percentage_project_manager = ((double)final_match_with_the_project_manager)/project_manager_total_score*100;

Console.WriteLine("Ваше совпадение " + final_match_with_the_project_manager + " из " + project_manager_total_score + " совпадение " + match_percentage_project_manager + "%");
Console.WriteLine(" ");
Console.WriteLine(" ");

// сверка совадений с продакт-менеджер
Console.WriteLine("Совпадения с продакт-менеджер");

int coincidence_with_the_product_manager_extrovert;

if (extrovert >= product_manager_extrovert)
{
    coincidence_with_the_product_manager_extrovert = product_manager_extrovert;
}
else
{
    coincidence_with_the_product_manager_extrovert = extrovert;
}

Console.WriteLine("Совпадении в критерии - экстраверт " + coincidence_with_the_product_manager_extrovert);

int coincidence_with_the_product_manager_introvert;

if (introvert >= product_manager_introvert)
{
    coincidence_with_the_product_manager_introvert = product_manager_introvert;
}
else
{
    coincidence_with_the_product_manager_introvert = introvert;
}

Console.WriteLine("Совпадении в критерии - интроверт " + coincidence_with_the_product_manager_introvert);

int coincidence_with_the_product_manager_аbility_to_work_monotonously;

if (аbility_to_work_monotonously >= product_manager_аbility_to_work_monotonously)
{
    coincidence_with_the_product_manager_аbility_to_work_monotonously = product_manager_аbility_to_work_monotonously;
}
else
{
    coincidence_with_the_product_manager_аbility_to_work_monotonously = аbility_to_work_monotonously;
}

Console.WriteLine("Совпадении в критерии - Способность к монотонной работе " + coincidence_with_the_product_manager_аbility_to_work_monotonously);

int coincidence_with_the_product_manager_мentoring;

if (мentoring >= product_manager_мentoring)
{
    coincidence_with_the_product_manager_мentoring = product_manager_мentoring;
}
else
{
    coincidence_with_the_product_manager_мentoring = мentoring;
}

Console.WriteLine("Совпадении в критерии - Наставничество " + coincidence_with_the_product_manager_мentoring);

int coincidence_with_the_product_manager_analytical_data;

if (analytical_data >= product_manager_analytical_data)
{
    coincidence_with_the_product_manager_analytical_data = product_manager_analytical_data;
}
else
{
    coincidence_with_the_product_manager_analytical_data = analytical_data;
}

Console.WriteLine("Совпадении в критерии - Аналитические навыки " + coincidence_with_the_product_manager_analytical_data);

int coincidence_with_the_product_manager_empathy;

if (empathy >= product_manager_empathy)
{
    coincidence_with_the_product_manager_empathy = product_manager_empathy;
}
else
{
    coincidence_with_the_product_manager_empathy = empathy;
}

Console.WriteLine("Совпадении в критерии - Эмпатия " + coincidence_with_the_product_manager_empathy);

int coincidence_with_the_product_manager_curiosity;

if (curiosity >= product_manager_curiosity)
{
    coincidence_with_the_product_manager_curiosity = product_manager_curiosity;
}
else
{
    coincidence_with_the_product_manager_curiosity = curiosity;
}

Console.WriteLine("Совпадении в критерии - Любопытство " + coincidence_with_the_product_manager_curiosity);

int coincidence_with_the_product_manager_oratory;

if (oratory >= product_manager_oratory)
{
    coincidence_with_the_product_manager_oratory = product_manager_oratory;
}
else
{
    coincidence_with_the_product_manager_oratory = oratory;
}

Console.WriteLine("Совпадении в критерии - Ораточрское искусство " + coincidence_with_the_product_manager_oratory);

int coincidence_with_the_product_manager_organizational_ability;

if (organizational_ability >= product_manager_organizational_ability)
{
    coincidence_with_the_product_manager_organizational_ability = product_manager_organizational_ability;
}
else
{
    coincidence_with_the_product_manager_organizational_ability = organizational_ability;
}

Console.WriteLine("Совпадении в критерии - Организаторские способности " + coincidence_with_the_product_manager_organizational_ability);

int coincidence_with_the_product_manager_critical_thinking;

if (critical_thinking >= product_manager_critical_thinking)
{
    coincidence_with_the_product_manager_critical_thinking = product_manager_critical_thinking;
}
else
{
    coincidence_with_the_product_manager_critical_thinking = critical_thinking;
}

Console.WriteLine("Совпадении в критерии - Критическое мышление " + coincidence_with_the_product_manager_critical_thinking);

int coincidence_with_the_product_manager_multitasking;

if (multitasking >= product_manager_multitasking)
{
    coincidence_with_the_product_manager_multitasking = product_manager_multitasking;
}
else
{
    coincidence_with_the_product_manager_multitasking = multitasking;
}

Console.WriteLine("Совпадении в критерии - Многозадачность " + coincidence_with_the_product_manager_multitasking);

int coincidence_with_the_product_manager_creativity;

if (creativity >= product_manager_creativity)
{
    coincidence_with_the_product_manager_creativity = product_manager_creativity;
}
else
{
    coincidence_with_the_product_manager_creativity = creativity;
}

Console.WriteLine("Совпадении в критерии - Креативность " + coincidence_with_the_product_manager_creativity);

int coincidence_with_the_product_manager_stress_tolerance;

if (stress_tolerance >= product_manager_stress_tolerance)
{
    coincidence_with_the_product_manager_stress_tolerance = product_manager_stress_tolerance;
}
else
{
    coincidence_with_the_product_manager_stress_tolerance = stress_tolerance;
}

Console.WriteLine("Совпадении в критерии - Стрессоустойчивость " + coincidence_with_the_product_manager_stress_tolerance);

int coincidence_with_the_product_manager_time_control;

if (time_control >= product_manager_time_control)
{
    coincidence_with_the_product_manager_time_control = product_manager_time_control;
}
else
{
    coincidence_with_the_product_manager_time_control = time_control;
}

Console.WriteLine("Совпадении в критерии - Контроль времени " + coincidence_with_the_product_manager_time_control);

int coincidence_with_the_product_manager_work_with_a_large_amount_of_data;

if (work_with_a_large_amount_of_data >= product_manager_work_with_a_large_amount_of_data)
{
    coincidence_with_the_product_manager_work_with_a_large_amount_of_data = product_manager_work_with_a_large_amount_of_data;
}
else
{
    coincidence_with_the_product_manager_work_with_a_large_amount_of_data = work_with_a_large_amount_of_data;
}

Console.WriteLine("Совпадении в критерии - Работа с большим объемом данных " + coincidence_with_the_product_manager_work_with_a_large_amount_of_data);

int final_match_with_the_product_manager = coincidence_with_the_product_manager_extrovert +
coincidence_with_the_product_manager_introvert +
coincidence_with_the_product_manager_аbility_to_work_monotonously +
coincidence_with_the_product_manager_мentoring +
coincidence_with_the_product_manager_analytical_data +
coincidence_with_the_product_manager_empathy +
coincidence_with_the_product_manager_curiosity +
coincidence_with_the_product_manager_oratory +
coincidence_with_the_product_manager_organizational_ability +
coincidence_with_the_product_manager_critical_thinking +
coincidence_with_the_product_manager_multitasking +
coincidence_with_the_product_manager_creativity +
coincidence_with_the_product_manager_stress_tolerance +
coincidence_with_the_product_manager_time_control +
coincidence_with_the_product_manager_work_with_a_large_amount_of_data;

double match_percentage_product_manager = ((double)final_match_with_the_product_manager)/product_manager_total_score*100;

Console.WriteLine("Ваше совпадение " + final_match_with_the_product_manager + " из " + product_manager_total_score + " совпадение " + match_percentage_project_manager + "%");
Console.WriteLine(" ");
Console.WriteLine(" ");