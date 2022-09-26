using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public static class AlexDay1 
{
    public static Dialog Get1(){
        return new Dialog(
            new Dictionary<string, Entry>(){
                {"Alex_Day1_1", new Entry(
                    "Alex_Day1_1", "Добрый день, Ярослав. Мне про вас всё рассказали. Думаю, у нас с вами не должно возникнуть никаких проблем. Вы догадываетесь, какой вариант для нас предпочтительный?$",
                    EntryType.Chain,
                    _id_transition:"Alex_Day1_20")},
                // Тюльпан 1
                {"Alex_Day1_20", new Entry(
                    "Alex_Day1_20", "",
                    EntryType.Tulip,
                    new List<Answer>{
                        new Answer("Странно, что мне о вас сообщили только имя и то, что вы студент. Не расскажешь о себе поподробнее?",
                        "Alex_Day1_21",
                        new Condition[]{
                            new Condition("Alex_Day1_21", ConditionType.IfFalse) 
                        },
                        new Trigger[]{
                            new Trigger("Alex_Day1_21", TriggerType.SetToTrue),
                        }), 

                        new Answer("Что же вы знатете обо мне, Алексей?",
                        "Alex_Day1_22",
                        new Condition[]{
                            new Condition("Alex_Day1_22", ConditionType.IfFalse)
                        },
                        new Trigger[]{
                            new Trigger("Alex_Day1_22", TriggerType.SetToTrue),
                        }), 

                        new Answer("Каким образом я посредством диалога с незнакомцами определю экстремистскую угрозу во всей социальной сети?",
                        "Alex_Day1_23",
                        new Condition[]{
                            new Condition("Alex_Day1_23", ConditionType.IfFalse),
                        },
                        new Trigger[]{
                            new Trigger("Alex_Day1_23", TriggerType.SetToTrue),
                        }),
                        // Переход в Конец
                        new Answer("Я обдумаю это, Алёша. Я не хочу обсуждать твои мысли обо мне и о моей деятельности. Если что - напишу о своём решении.",
                        "Alex_Day1_30",
                        new Condition[]{
                            new Condition("Alex_Day1_30", ConditionType.IfFalse ),
                        },
                        new Trigger[]{
                            new Trigger("Alex_Day1_30", TriggerType.SetToTrue),
                        }),
                    })},
                {"Alex_Day1_21", new Entry(
                    "Alex_Day1_21", "Что же я могу рассказать? Родился, учился - пока не доучился, не женился и не умер. Студент, люблю приватную жизнь и не особо распространяться о себе. Понятно? Простите, если грубо, но я, право, не знаю, что о себе рассказать. Здесь я постараюсь не сильно выдать себя, чего и вам советую.",
                    EntryType.Chain,
                    _id_transition:"Alex_Day1_20")},
                {"Alex_Day1_22", new Entry(
                    "Alex_Day1_22", "Ну как же, известный прапорщик Чуев! Если честно, я знаю, что вы военный, и что вы 'Чуев'. Не более. Что ещё ожидать от руководства моего университета? Личное досье на вас мне никто не предоставит.",
                    EntryType.Chain,
                    _id_transition:"Alex_Day1_20")},
                {"Alex_Day1_23", new Entry(
                    "Alex_Day1_23", "Поробуйте представить. Вы проводите расследование по одной причине, а я совсем по другой. У вас своё исследование, возможно необходимое исключительно вашему начальнику, а изучаю эту платфому, с целью открытия новых горизонтов для социологии! Действительно, для 'ваших' - это может оказаться всего лишь дополнительной галочкой, не более!"+
                    "План очень прост. Как мне кажется, ваше мнение, может сыграть ключевую роль в безопасности страны! Поэтому, отправьте в штаб абсолютно любое своё решение об этом мессенджере и вернитесь к выполнению своих воинских обязанностей. Этим вы освободите меня, от переписки с вами, и дадите больше возможностей для изучения людей.",
                    EntryType.Chain,
                    _id_transition:"Alex_Day1_20")},
                // Переход в Конец
                {"Alex_Day1_30", new Entry(
                    "Alex_Day1_30", "О, это совсем необязательно. Если вы продолжите мне писать - я буду отвечать, пока не прекратите. Если же передадите своё заключение начальству, то мне автоматически придёт письмо. Надеюсь, вы примете лучшее решение!",
                    EntryType.End,
                    _id_transition:"HQ_Day1_20")},
                
            }
        );
    }
}
