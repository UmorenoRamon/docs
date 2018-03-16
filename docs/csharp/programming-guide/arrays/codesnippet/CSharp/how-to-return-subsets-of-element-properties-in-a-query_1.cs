                class Student {
                  public string FirstName;
                  public string LastName;
                  public float[] ExamScores;
	              };
                private static void QueryByScore()
                {
                  	var students = new Student[] {
                      new Student{ FirstName = "Terry", LastName = "Adams", ExamScores = new float[] {96, 100}}, 
                      new Student{ FirstName = "Fakhouri", LastName = "Fadi", ExamScores = new float[] {100, 100}}
                      new Student{ FirstName = "Cesar", LastName = "Garcia", ExamScores = new float[] {100, 100}}
                      new Student{ FirstName = "Svetlana", LastName = "Omelchenko", ExamScores = new float[] {100, 100}}
                      new Student{ FirstName = "Eugene", LastName = "Zabokritski", ExamScores = new float[] {100, 100}}
                      new Student{ FirstName = "John", LastName = "Doe", ExamScores = new float[] {80, 100}}
              	};

                  
                    // Create the query. var is required because
                    // the query produces a sequence of anonymous types.
                    var queryHighScores =
                        from student in students
                        where student.ExamScores[0] > 95
                        select new { student.FirstName, student.LastName };

                    // Execute the query.
                    foreach (var obj in queryHighScores)
                    {
                        // The anonymous type's properties were not named. Therefore 
                        // they have the same names as the Student properties.
                        Console.WriteLine(obj.LastName + ", " + obj.FirstName);
                    }
                }
                /* Output:
                Adams, Terry
                Fakhouri, Fadi
                Garcia, Cesar
                Omelchenko, Svetlana
                Zabokritski, Eugene
                */
