﻿using System;
using System.ComponentModel.Design;
using System.Reflection.Metadata.Ecma335;
using projCharacter;
using static System.Runtime.InteropServices.JavaScript.JSType;


class MainProgram
{
    public static void Main(string[] args)
    {
        Character j1 = new Character("Paul", "20", "40", "50");
        Character j2 = new Character();

        j1.Combat(j2);

        }

    
    
 }