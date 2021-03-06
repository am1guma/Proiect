﻿using AggregationRoots.Factories;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValueObjects;

namespace UI
{
    class Program
    {
        static void Main(string[] args)
        {
            var u = FactoryUniversitate.Instance.CreeazaUniversitate(new NumeUniversitate("UPT"));
            u.CreeazaFacultate(new Facultate(new NumeFacultate("AC")));
            u.Facultati[0].CreeazaSecretariat(new Secretariat(new NumeSecretariat("Secretariat AC")));
            u.Facultati[0].Secretariat.CreeazaStudent(new Student(
                new NumarMatricol(7432), new Nume("Palcu"), new Prenume("Oana Maria"),new DataNasterii(new DateTime(1993,8,16)),
                new CNP("28426298446329805"), new Sectie("IS"), new AnUniversitar(4), new Grupa(2)));
            u.Facultati[0].Secretariat.CreeazaProfesor(new Profesor(
                new Nume("Groza"), new Prenume("Cristian"), new DataNasterii(new DateTime(1992, 8, 8)), new CNP("1868236784643786543")));
            u.Facultati[0].Secretariat.Profesori[0].CreeazaDisciplina(new Disciplina(new Materia("PSSC"), new TipPredare("laborator")));
            u.Facultati[0].Secretariat.Profesori[0].CreeazaDisciplina(new Disciplina(new Materia("DATC"), new TipPredare("laborator")));
            u.Facultati[0].Secretariat.Profesori[0].CreeazaSituatie(u.Facultati[0].Secretariat.Studenti[0], u.Facultati[0].Secretariat.Profesori[0].Discipline[0].Materia, new Nota(9));
            u.Facultati[0].Secretariat.Profesori[0].CreeazaSituatie(u.Facultati[0].Secretariat.Studenti[0], u.Facultati[0].Secretariat.Profesori[0].Discipline[1].Materia, new Nota(10));

            u.Facultati[0].Secretariat.CreeazaStudent(new Student(
                new NumarMatricol(1432), new Nume("Meici"), new Prenume("Vlad Alexandru"), new DataNasterii(new DateTime(1993, 8, 3)),
                new CNP("18426298446329805"), new Sectie("IS"), new AnUniversitar(4), new Grupa(2)));
            u.Facultati[0].Secretariat.CreeazaProfesor(new Profesor(
                new Nume("Dan"), new Prenume("Ana"), new DataNasterii(new DateTime(1980, 8, 8)), new CNP("1868236784643786543")));
            u.Facultati[0].Secretariat.Profesori[0].CreeazaDisciplina(new Disciplina(new Materia("PSSC"), new TipPredare("laborator")));
            u.Facultati[0].Secretariat.Profesori[0].CreeazaDisciplina(new Disciplina(new Materia("DATC"), new TipPredare("laborator")));
            u.Facultati[0].Secretariat.Profesori[0].CreeazaSituatie(u.Facultati[0].Secretariat.Studenti[1], u.Facultati[0].Secretariat.Profesori[0].Discipline[0].Materia, new Nota(5));
            u.Facultati[0].Secretariat.Profesori[0].CreeazaSituatie(u.Facultati[0].Secretariat.Studenti[1], u.Facultati[0].Secretariat.Profesori[0].Discipline[1].Materia, new Nota(6));

            Console.WriteLine("Universitate: "+u);
            Console.WriteLine("Facultate: "+u.Facultati[0]);
            Console.WriteLine("Secretariat: " + u.Facultati[0].Secretariat);
            Console.WriteLine("Student: " + u.Facultati[0].Secretariat.Studenti[0]);
            Console.WriteLine("Profesor: " + u.Facultati[0].Secretariat.Profesori[0]);
            Console.WriteLine("Disciplina: " + u.Facultati[0].Secretariat.Profesori[0].Discipline[0]);
            Console.WriteLine(u.Facultati[0].Secretariat.Studenti[0].VizualizeazaSituatie());
            Console.WriteLine();

            var c = FactoryCamin.Instance.CreeazaCamin(new NumeCamin("Caminul 1MV"));
            c.CreeazaAdministrator(new Administrator(new NumeAdministrator("Lisy")));

            Console.WriteLine("Camin: " + c);
            Console.WriteLine("Administrator: " + c.Administrator);
            Console.WriteLine(c.SelectareStudentiCamin(u.Facultati[0].Secretariat.Studenti, 5, 10));
            Console.ReadKey();
        }
    }
}
