﻿using System;
using System.Reflection;

namespace ConsoleApp18
{
    internal class Program
    {
        static void Main()
        {
            Type type = typeof(Attribute);
            MethodInfo[] methods = type.GetMethods();

            foreach (MethodInfo method in methods)
            {
                Console.WriteLine("Method: " + method.Name);
                Console.WriteLine("IsAbstract: " + method.IsAbstract);
                Console.WriteLine("IsFamily: " + method.IsFamily);
                Console.WriteLine("IsFamilyAndAssembly: " + method.IsFamilyAndAssembly);
                Console.WriteLine("IsFamilyOrAssembly: " + method.IsFamilyOrAssembly);
                Console.WriteLine("IsAssembly: " + method.IsAssembly);
                Console.WriteLine("IsPrivate: " + method.IsPrivate);
                Console.WriteLine("IsPublic: " + method.IsPublic);
                Console.WriteLine("IsConstructor: " + method.IsConstructor);
                Console.WriteLine("IsStatic: " + method.IsStatic);
                Console.WriteLine("IsVirtual: " + method.IsVirtual);
                Console.WriteLine("ReturnType: " + method.ReturnType);
            }

            
            ConstructorInfo[] constructors = type.GetConstructors();

            foreach (ConstructorInfo constructor in constructors)
            {
                Console.WriteLine("Constructor: " + constructor.Name);
                Console.WriteLine("IsFamily: " + constructor.IsFamily);
                Console.WriteLine("IsFamilyAndAssembly: " + constructor.IsFamilyAndAssembly);
                Console.WriteLine("IsFamilyOrAssembly: " + constructor.IsFamilyOrAssembly);
                Console.WriteLine("IsAssembly: " + constructor.IsAssembly);
                Console.WriteLine("IsPrivate: " + constructor.IsPrivate);
                Console.WriteLine("IsPublic: " + constructor.IsPublic);
            }

            System.Reflection.FieldInfo[] fields = type.GetFields();

            foreach (FieldInfo field in fields)
            {
                Console.WriteLine("Field: " + field.Name);
                Console.WriteLine("IsFamily: " + field.IsFamily);
                Console.WriteLine("IsFamilyAndAssembly: " + field.IsFamilyAndAssembly);
                Console.WriteLine("IsFamilyOrAssembly: " + field.IsFamilyOrAssembly);
                Console.WriteLine("IsAssembly: " + field.IsAssembly);
                Console.WriteLine("IsPrivate: " + field.IsPrivate);
                Console.WriteLine("IsPublic: " + field.IsPublic);
                Console.WriteLine("IsStatic: " + field.IsStatic);
            }


            System.Reflection.PropertyInfo[] properties = type.GetProperties();

            foreach (System.Reflection.PropertyInfo property in properties)
            {
                Console.WriteLine("Property: " + property.Name);
                Console.WriteLine("Attributes: " + property.Attributes);
                Console.WriteLine("CanRead: " + property.CanRead);
                Console.WriteLine("CanWrite: " + property.CanWrite);
                Console.WriteLine("GetMethod: " + property.GetMethod);
                Console.WriteLine("SetMethod: " + property.SetMethod);
                Console.WriteLine("PropertyType: " + property.PropertyType);
            }
        }
    }
}
