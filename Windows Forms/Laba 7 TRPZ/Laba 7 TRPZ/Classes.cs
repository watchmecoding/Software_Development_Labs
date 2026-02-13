using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_7_TRPZ
{
    // Базовий клас "Тварина"
    public class Animal: MyObject
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string Habitat { get; set; }

        public Animal(string name, int age, string gender, string habitat)
        {
            Name = name;
            Age = age;
            Gender = gender;
            Habitat = habitat;
        }

        public override string GetInformation()
        { return $"Animal Type: {GetType().Name};\nName: {Name};\nAge: {Age};\nGender: {Gender};\nHabitat: {Habitat}\n"; }

        public override void GetInformationInConsole() 
        {
            Console.WriteLine(GetInformation());
        }
        public override void GetInformationInWindow()
        {
            MessageBox.Show(GetInformation(), $"Information about {GetType().Name} {Name}", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }

    // Похідний клас "Ссавець"
    public class Mammal : Animal
    {
        public string Legs { get; set; }
        public string Tail { get; set; }
        public double ToothDiameter { get; set; }
        public string FurColors { get; set; }

        public Mammal(string name, int age, string gender, string habitat, string legs, string tail, double toothDiameter, string furColors)
            : base(name, age, gender, habitat)
        {
            Legs = legs;
            Tail = tail;
            ToothDiameter = toothDiameter;
            FurColors = furColors;
        }
        public override string GetInformation()
        {
            return $"{base.GetInformation()}Legs: {Legs};\nTail: {Tail};\nTooth diameter: {ToothDiameter};\nFur color: {FurColors};\n";
        }
    }

    // Похідний клас "Птах"
    public class Bird : Animal
    {
        public string Wings { get; set; }
        public string Beak { get; set; }
        public string FlightType { get; set; }
        public string FeatherColor { get; set; }

        public Bird(string name, int age, string gender, string habitat, string wings, string beak, string flightType, string featherColor)
            : base(name, age, gender, habitat)
        {
            Wings = wings;
            Beak = beak;
            FlightType = flightType;
            FeatherColor = featherColor;
        }

        public override string GetInformation()
        {
            return $"{base.GetInformation()}Wings: {Wings};\nBeak: {Beak};\nFlight type:{FlightType};\nFeather color: {FeatherColor};\n";
        }
    }

    // Похідний клас "Синиця" від "Птах"
    public class BlueTit : Bird
    {
        public string DietType { get; set; }
        public string Size { get; set; }
        public string Family { get; set; }
        public string MigrationRoute { get; set; }

        public BlueTit(string name, int age, string gender, string habitat, string wings, string beak, string flightType, string featherColor,
            string dietType, string size, string family, string migrationRoute)
            : base(name, age, gender, habitat, wings, beak, flightType, featherColor)
        {
            DietType = dietType;
            Size = size;
            Family = family;
            MigrationRoute = migrationRoute;
        }

        public override string GetInformation()
        {
            return $"{base.GetInformation()}Diet type: {DietType};\nSize: {Size};\nFamily: {Family};\nMigration route: {MigrationRoute};\n";
        }
    }

    // Похідний клас "Лев" від "Ссавця"
    public class Lion : Mammal
    {
        public string FeedingType { get; set; }
        public string ManeSize { get; set; }
        public string SocialStructure { get; set; }
        public double BodyWeight { get; set; }

        public Lion(string name, int age, string gender, string habitat, string legs, string tail, double toothDiameter, string furColors,
            string feedingType, string maneSize, string socialStructure, double bodyWeight)
            : base(name, age, gender, habitat, legs, tail, toothDiameter, furColors)
        {
            FeedingType = feedingType;
            ManeSize = maneSize;
            SocialStructure = socialStructure;
            BodyWeight = bodyWeight;
        }
        public override string GetInformation()
        {
            return $"{base.GetInformation()}Feeding type: {FeedingType};\nMane size: {ManeSize};\nSocial structure: {SocialStructure};\nBody weight: {BodyWeight};\n";
        }
    }

    // Похідний клас "Дельфін" від "Ссавця"
    public class Dolphin : Mammal
    {
        public string SwimmingStyle { get; set; }
        public string FinSize { get; set; }
        public string Communication { get; set; }
        public double AverageSpeed { get; set; }

        public Dolphin(string name, int age, string gender, string habitat, string legs, string tail, double toothDiameter, string furColors,
            string swimmingStyle, string finSize, string communication, double averageSpeed)
            : base(name, age, gender, habitat, legs, tail, toothDiameter, furColors)
        {
            SwimmingStyle = swimmingStyle;
            FinSize = finSize;
            Communication = communication;
            AverageSpeed = averageSpeed;
        }
        public override string GetInformation()
        {
            return $"{base.GetInformation()}Swimming style: {SwimmingStyle};\nFin size: {FinSize};\nCommunications: {Communication};\nAverage speed: {AverageSpeed};\n";
        }
    }
}