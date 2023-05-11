using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacebookModel
{
    public class TimeWellSpend
    {
        public Dictionary<TimeSpan, List<string>> m_BetterThingsToDoDic { get; set; }

        public TimeWellSpend()
        {
            m_BetterThingsToDoDic = new Dictionary<TimeSpan, List<string>>()
                                      {
                                          {
                                              TimeSpan.FromSeconds(0),
                                              new List<string>
                                                  {
                                                      "Blink :)"
                                                  }
                                          },
                                          {
                                              TimeSpan.FromSeconds(10),
                                              new List<string>
                                                  {
                                                      "Take a deep breath",
                                                      "Drink a sip of water",
                                                      "Stretch your arms",
                                                      "Close your eyes and count to 10"
                                                  }
                                          },
                                          {
                                              TimeSpan.FromSeconds(20),
                                              new List<string>
                                                  {
                                                      "Take a few deep breaths",
                                                      "Do a quick mindfulness exercise",
                                                      "Hum a tune you like",
                                                      "Say a positive affirmation to yourself"
                                                  }
                                          },
                                          {
                                              TimeSpan.FromSeconds(30),
                                              new List<string>
                                                  {
                                                      "Stand up and walk around",
                                                      "Do a quick dance",
                                                      "Send a positive message to a friend",
                                                      "Make a to-do list for the day"
                                                  }
                                          },
                                          {
                                              TimeSpan.FromSeconds(40),
                                              new List<string>
                                                  {
                                                      "Do a quick set of squats",
                                                      "Stretch your legs",
                                                      "Write down something you're grateful for",
                                                      "Visualize yourself succeeding at something"
                                                  }
                                          },
                                          {
                                              TimeSpan.FromSeconds(50),
                                              new List<string>
                                                  {
                                                      "Listen to a short guided meditation",
                                                      "Do a quick desk workout",
                                                      "Write a quick thank-you note",
                                                      "Do a mental visualization exercise"
                                                  }
                                          },
                                          {
                                              TimeSpan.FromMinutes(1),
                                              new List<string>
                                                  {
                                                      "Do a few push-ups",
                                                      "Meditate for a minute",
                                                      "Listen to a favorite song",
                                                      "Do a mini relaxation exercise",
                                                      "Take a moment to appreciate the environment around you",
                                                      "Do a quick body scan to check for tension",
                                                      "Think of someone you love and send them positive thoughts",
                                                      "Try a new stretch",
                                                      "Take a moment to smile and relax your facial muscles"
                                                  }
                                          },
                                          {
                                              TimeSpan.FromMinutes(2),
                                              new List<string>
                                                  {
                                                      "Take a longer walk around the block",
                                                      "Do a few minutes of stretching",
                                                      "Write a brief journal entry",
                                                      "Make a cup of tea and enjoy it mindfully",
                                                      "Listen to a short guided meditation",
                                                      "Do a quick body weight workout",
                                                      "Write a short story or poem",
                                                      "Practice deep breathing exercises",
                                                      "Reflect on a recent accomplishment and feel proud",
                                                      "Do a quick desk yoga routine"
                                                  }
                                          },
                                          {
                                              TimeSpan.FromMinutes(5),
                                              new List<string>
                                                  {
                                                      "Take a short walk outside",
                                                      "Read a few pages of a book",
                                                      "Write in a journal",
                                                      "Do a simple yoga routine",
                                                      "Make a cup of tea and enjoy it mindfully",
                                                      "Listen to a favorite podcast or audiobook",
                                                      "Do a few minutes of guided meditation",
                                                      "Do a quick home workout",
                                                      "Try a new recipe",
                                                      "Take a moment to reflect on your goals and plan your next steps"
                                                  }
                                          },
                                          {
                                              TimeSpan.FromMinutes(10),
                                              new List<string>
                                                  {
                                                      "Do a quick workout",
                                                      "Practice mindfulness meditation",
                                                      "Call a friend or family member",
                                                      "Make a healthy snack",
                                                      "Take a short nap or rest",
                                                      "Write a letter or email to someone you admire",
                                                      "Do a simple DIY project",
                                                      "Take a relaxing bath or shower",
                                                      "Listen to a guided meditation",
                                                      "Do a few minutes of stretching and yoga"
                                                  }
                                          },
                                          {
                                              TimeSpan.FromMinutes(20),
                                              new List<string>
                                                  {
                                                      "WHAT IS WRONG WITH YOU?!"
                                                  }
                                          }
                                      };
        }

        public string GetActivity(DateTime i_StartTime)
        {
            string activityToReturn = null;
            DateTime now = DateTime.Now;
            TimeSpan interval = now - i_StartTime;
            TimeSpan closestTimeDiff = TimeSpan.MaxValue;
            TimeSpan closestDateTime = TimeSpan.MinValue;

            foreach (TimeSpan key in m_BetterThingsToDoDic.Keys)
            {
                TimeSpan timeDiff = interval.Subtract(key);
                if (timeDiff >= TimeSpan.Zero && timeDiff < closestTimeDiff)
                {
                    closestTimeDiff = timeDiff;
                    closestDateTime = key;
                }
            }
            if (m_BetterThingsToDoDic.ContainsKey(closestDateTime))
            {
                List<string> activityList = m_BetterThingsToDoDic[closestDateTime];
                Random random = new Random();
                activityToReturn = activityList[random.Next(activityList.Count)];
            }

            return activityToReturn;
        }
    }
}

