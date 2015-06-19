using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.IO;


namespace AspPerformanceComparison.Data
{
    public static class Persons
    {
        public static Person ARandomOne()
        {
            Random r = new Random();
            Person p = new Person();
            p.Gender = Genders[r.Next(Genders.Length)];
            if (p.Gender == Gender.Male)
                p.FirstName = MaleNames[r.Next(MaleNames.Length)];
            else
                p.FirstName = FemaleNames[r.Next(FemaleNames.Length)];
            p.LastName = LastNames[r.Next(LastNames.Length)];
            p.Age = r.Next(90)+10;
            p.Occupation = Occupations[r.Next(Occupations.Length)];
            p.Education = Universities[r.Next(Universities.Length)];
            p.Degree = Degrees[r.Next(Degrees.Length)];
            p.Weight = r.Next(60)+40;
            p.Height = r.Next(80) + 140;
            p.MaritalStatus = MaritalStatuses[r.Next(MaritalStatuses.Length)];

            return p;
        }


        static String[] MaleNames;
        static String[] FemaleNames;
        static String[] LastNames;
        static Gender[] Genders = new Gender[] { Gender.Male, Gender.Female };
        static String[] Occupations;
        static String[] Universities;
        static String[] Degrees = new String[] { "B.S.", "M.S.", "Ph. D", "B.A", "M.A.", "Th.D.", "Ed.D", "Psy.D.",  "M.D.", "J.D" };
        static MaritalStatus[] MaritalStatuses = new MaritalStatus[] { MaritalStatus.Single, MaritalStatus.Single, MaritalStatus.Married, MaritalStatus.Married, MaritalStatus.Divorced};

        static Persons()
        {
            LastNames = readResource(AspPerformanceComparison.Properties.Resources.Lastnames);
            MaleNames = readResource(AspPerformanceComparison.Properties.Resources.Malenames);
            FemaleNames = readResource(AspPerformanceComparison.Properties.Resources.Femalenames);
            Occupations = readResource(AspPerformanceComparison.Properties.Resources.Occupations);
            Universities = readResource(AspPerformanceComparison.Properties.Resources.Universities);
        }

        static string[] readResource(string resourse)
        {
            return resourse.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
        }
    }

}
