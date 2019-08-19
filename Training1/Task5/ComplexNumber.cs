using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training1.Task5
{
    public class ComplexNumber
    {
        #region Fields&&Constructor

        private int real;

        private int imaginary;

        public ComplexNumber(int real, int imaginary)
        {
            this.real = real;
            this.imaginary = imaginary;
        }

        #endregion Fields&&Constructor

        #region Operators

        public static ComplexNumber operator /(ComplexNumber number1, ComplexNumber number2)
        {
            return new ComplexNumber(
                       (number1.real * number2.real + number1.imaginary * number2.imaginary) /
                       ((number2.real * number2.real) + (number2.imaginary * number2.imaginary)),
                       (number1.imaginary * number2.real - number1.real * number2.imaginary) /
                       ((number2.real * number2.real) + (number2.imaginary * number2.imaginary)));
        }

        public static ComplexNumber operator *(ComplexNumber number1, ComplexNumber number2)
        {
            return new ComplexNumber(
                       number1.real * number2.real - number1.imaginary * number2.imaginary,
                       number1.imaginary * number2.real + number1.real * number2.imaginary);
        }

        public static ComplexNumber operator -(ComplexNumber number1, ComplexNumber number2)
        {
            return new ComplexNumber(
                       number1.real - number2.real,
                       number1.imaginary - number2.imaginary);
        }

        public static ComplexNumber operator +(ComplexNumber number1, ComplexNumber number2)
        {
            return new ComplexNumber(
                       number1.real + number2.real,
                       number1.imaginary + number2.imaginary);
        }

        public static bool operator ==(ComplexNumber number1, ComplexNumber number2) => ComplexNumber.Equals(number1, number2);

        public static bool operator !=(ComplexNumber number1, ComplexNumber number2) => !ComplexNumber.Equals(number1, number2);

        #endregion Operstors

        #region OveerideObjectMethod

        public override bool Equals(object obj)
        {
            var other = obj as ComplexNumber;
            if (other == null)
            {
                return false;
            }

            return (other.real == this.real) && (other.imaginary == this.imaginary);
        }

        public override string ToString()
        {
            return $"ComplexNumber = {this.real} + {this.imaginary}i";
        }

        #endregion OveerideObjectMethod
    }
}
