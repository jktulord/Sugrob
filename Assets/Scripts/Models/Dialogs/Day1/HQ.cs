using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public static class HQDay1
{
    public static Dialog Get(){
        
            Entry HQ_Day1_1 = new Entry(
                    "HQ_Day1_1", "Товарищ прапорщик, мы хотим напомить вам, о ваших заслугах перед родиной и отечеством. Ваши заслуги, конечно, неизмеримы. $ $"
                    +"В нашем пониманни - нельзя измерить то, чего нет. Наша страна находится в плато безопасности и стремится к светлому будущему. Такая вещь как экстремизм - отсутствует. Вы всё сами понимаите, Чуев.$ $"
                    +"Итак, приказ.$ $" 
                    +"В соответствии с приказом  зам.зав.глав.рас.ком.упр, Ярослав Чуев в срочном порядке переводится в анти-террористический коммисариат информационной единицы информационно-вычислительное устройство - компьютер личный с целью определения угроз сохранения мира во всём мире.$ $" 
                    +"Поздравляем!$"
                    +"Должность вашего куратора определена за мной. Я - безымянный специалист техподдержки #630654.$"
                    +"Ваш напарник - Алексей Кардович. Студент-социолог, рекомендованный к этому опасному заданию.$ $"
                    +"Вам предстоит определить степень угрозы новой, социальальной сети 'Сугроб 0.5'. Определите это при помощи интернет-переписки со случайными объектами.$"
                    +"Время на выполнение задания - 4 рабочих дня. Сверхурочные часы оплачиваться не будут.$"
                    +"Вам может помочь Алексей, хотя он находится в той же ситуаци, что и вы.$"
                    +"По особо важным вопросам - обращайтесь ко мне.$",
                    EntryType.Chain,
                    _triggers: new Trigger[]{
                        new Trigger("HQ_Day1_Theme1Counter", TriggerType.Add1ToInt),
                        new Trigger("HQ_Day1_Theme1Counter", TriggerType.Add1ToInt),
                        new Trigger("HQ_Day1_Theme1Counter", TriggerType.Add1ToInt),
                    },
                    _id_transition:"HQ_Day1_20");

            Entry HQ_Day1_20 = new Entry(
                    "HQ_Day1_20", "",
                    EntryType.Tulip,
                    new List<Answer>{
                        new Answer("Кто вы? Как к вам обращатьтся? Какое у вас воинское звание?",
                        "HQ_Day1_21",
                        new Condition[]{
                            new Condition("HQ_Day1_21", ConditionType.IfFalse)
                        },
                        new Trigger[]{
                            new Trigger("HQ_Day1_21", TriggerType.SetToTrue),
                            new Trigger("HQ_Day1_Theme1Counter", TriggerType.Sub1ToInt),
                        }),
                         
                        new Answer("Почему я назначаюсь на такое ответственное задание вместо слубжы в своей воинской части?",
                        "HQ_Day1_22",
                        new Condition[]{
                            new Condition("HQ_Day1_22", ConditionType.IfFalse)
                        },
                        new Trigger[]{
                            new Trigger("HQ_Day1_22", TriggerType.SetToTrue),
                            new Trigger("HQ_Day1_Theme1Counter", TriggerType.Sub1ToInt)
                        }),

                        new Answer("Каким образом я посредством диалога с незнакомцами определю экстремистскую угрозу во всей социальной сети?",
                        "HQ_Day1_23",
                        new Condition[]{
                            new Condition("HQ_Day1_23", ConditionType.IfFalse)
                        },
                        new Trigger[]{
                            new Trigger("HQ_Day1_23", TriggerType.SetToTrue),
                            new Trigger("HQ_Day1_Theme1Counter", TriggerType.Sub1ToInt)
                        }), 

                        new Answer( "Позвольте предположить - вы в такой же ситуации, что и я? У вас тоже украли отпускные дни и бросили на сумбурное и неопределённое задание? Потому как это всё очень странно! ",
                        "HQ_Day1_25",
                        new Condition[]{
                            new Condition("HQ_Day1_25", ConditionType.IfFalse),
                            new Condition("HQ_Day1_Theme1Counter", ConditionType.IfInt0)
                        },
                        new Trigger[]{
                            new Trigger("HQ_Day1_25", TriggerType.SetToTrue)
                        }), 

                        new Answer("Всё предельно ясно. К выполнению задания приступить готов!",
                        "HQ_Day1_24",
                        new Condition[]{
                            new Condition("HQ_Day1_24", ConditionType.IfFalse)
                        },
                        new Trigger[]{
                            new Trigger("HQ_Day1_24", TriggerType.SetToTrue)
                        }), 
                    });
            Entry HQ_Day1_21 = new Entry(   
                    "HQ_Day1_21", "Я анонимный специалист тех.поддержки. Лишний раз ко мне обращаться - не нужно. Вам должно быть достаточно того, что у нас общий работодатель в лице годусарства. Мы - бюджетники и оба понимаем, что лишняя связь нам - ни к чему.",
                    EntryType.Chain,
                    _id_transition:"HQ_Day1_20");
            Entry HQ_Day1_22 = new Entry(
                    "HQ_Day1_22", "Вам назначен дополнительный, внеплановый отпуск со специальными условиями. Отпуск предоставляется на четыре дня. Специальные условия: в ходе этих четыёх дней вы будете выполнять ваше задание. Руководство уже вычло эти дни из вашего основного отпуска. Наслаждайтесь отдыхом!",
                    EntryType.Chain,
                    _id_transition:"HQ_Day1_20");
            Entry HQ_Day1_23 = new Entry(
                    "HQ_Day1_23", "Вам необходимо посредством техники продвинутого опроса распознать угрозу для безопасности. Задавайте вопросы собеседникам и внимательно читайте то, что они пишут. Это очень ответственная миссия, но она полне себе 'possible'. В сложных вопросах пишите своему напарнику Алексею, в случае особо сложных - можете мне, но я могу и не ответить, так как очень занят. ",
                    EntryType.Chain,
                    _id_transition:"HQ_Day1_20");
            Entry HQ_Day1_24 = new Entry(
                    "HQ_Day1_24", "Желаем успехов! Списка потенциальных собеседников нет, так что действуйте по обстоятельствам. Импровизируйте!",
                    EntryType.Chain,
                    _id_transition:"HQ_Day1_20");
            Entry HQ_Day1_25 = new Entry(
                    "HQ_Day1_25", "Сложно сказать. На самом деле - я в отпуске, а вы выполняете мою работу. Даже находясь в отпуске - я должен таким как вы помогать и инструктировать. Подумать только, ЧЕТЫРЕ дня отпуска и тратить на что? На выполнение рабочих обязанностей? Постарайтесь сюда не писать, так как я хочу найти хотя бы немного времени на личную жизнь. Если повезёт, может даже смогу отправиться в магазин лично, а не как обычно - писать объяснительную о том, что отсутствовал на протяжении трёх минут, из-за того, что получил заказ от курьера.",
                    EntryType.Chain,
                    _id_transition:"HQ_Day1_20");
                
        Dictionary<string, Entry> Entries = new Dictionary<string, Entry>();
        Entries.Add("HQ_Day1_1", HQ_Day1_1);
        Entries.Add("HQ_Day1_20", HQ_Day1_20);
        Entries.Add("HQ_Day1_21", HQ_Day1_21);
        Entries.Add("HQ_Day1_22", HQ_Day1_22);
        Entries.Add("HQ_Day1_23", HQ_Day1_23);
        Entries.Add("HQ_Day1_24", HQ_Day1_24);
        Entries.Add("HQ_Day1_25", HQ_Day1_25);
        return new Dialog(Entries);

    }
}