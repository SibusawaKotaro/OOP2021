﻿using System.Collections.Generic;
using System.IO;

namespace Test01 {
    class ScoreCounter {
        private IEnumerable<Student> _score;
        
        // コンストラクタ
        public ScoreCounter(string filePath) {
            _score = ReadScore(filePath);

        }


        //StudentScoreデータを読み込み、Studentオブジェクトのリストを返す： 
        private static IEnumerable<Student> ReadScore(string filePath) {
            var students = new List<Student>();
            var lines = File.ReadAllLines(filePath);
            foreach (string line in lines) {
                var items = line.Split(',');
                var student = new Student {
                    Name = items[0],
                    Subject = items[1],
                    Score = int.Parse(items[2])
                };
                students.Add(student);
            }
            return students;
        }

        //科目別の点数を集計する： 
        public IDictionary<string, int> GetPerStudentScore() {
            var dict = new Dictionary<string, int>();
            foreach (var student in _score) {
                if (dict.ContainsKey(student.Subject))
                    dict[student.Subject] += student.Score;
                else
                    dict[student.Subject] = student.Score;
            }
            return dict;
        }
    }
}
