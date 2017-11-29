using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*Kreirati bibilioteku Calculation sa klasom Calculator čiji su funkcijski članovi sljedeći: Add() ,
Subtract() , Multipy() , Divide() . Definirati svaku funkciju tako da ima 2 parametra i da vraća
rezultat ovisno o operaciji.*/

namespace Calculation
{
    public class Calculator
    {
        public float Add(float fPrviBroj, float fDrugiBroj)
        {
            return fPrviBroj + fDrugiBroj;
        }
        public float Substract(float fPrviBroj, float fDrugiBroj)
        {
            return fPrviBroj - fDrugiBroj;
        }
        public float Multiply(float fPrviBroj, float fDrugiBroj)
        {
            return fPrviBroj * fDrugiBroj;
        }
        public float Divide(float fPrviBroj, float fDrugiBroj)
        {
            return fPrviBroj / fDrugiBroj;
        }
    }
}
