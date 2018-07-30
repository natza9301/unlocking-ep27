using System;
using FluentAssertions;
using FluentAssertions.Collections;
using Moq;
using Xunit;

namespace temperature.test {
    public class UnitTest1 {
        [Theory (DisplayName = "เปลี่ยนค่า องศา Fahrenheit ให้เป็น Celsius ได้สำเร็จ")]
        [InlineData (32, 0)]
        public void ConvertFahrenheitToCelsiusSuccess (double input, double expectedResult) {
            var cal = new TempCalculator ();
            var x = cal.ConvertFahrenheitToCelsius (input);

            x.Should ().Be (expectedResult);
        }

        [Theory (DisplayName = "เปลี่ยนค่า องศา Kelvin ให้เป็น Celsius ได้สำเร็จ")]
        [InlineData (363.15, 90)]
        public void ConvertKelvinToCelsiusSuccess (double input, double expectedResult) {
            var cal = new TempCalculator ();
            var x = cal.ConvertKelvinToCelsius (input);

            x.Should ().Be (expectedResult);
        }

        [Theory (DisplayName = "เปลี่ยนค่า องศา celsius ให้เป็น Fahrenheit ได้สำเร็จ")]
        [InlineData (90, 194)]
        public void ConvertCelsiusToFahrenheitSuccess (double input, double expectedResult) {
            var cal = new TempCalculator ();
            var x = cal.ConvertCelsiusToFahrenheit (input);

            x.Should ().Be (expectedResult);
        }

        [Theory (DisplayName = "เปลี่ยนค่า องศา Kelvin ให้เป็น Fahrenheit ได้สำเร็จ")]
        [InlineData (90, -297.67)]
        public void ConvertKelvinToFahrenheitSuccess (double input, double expectedResult) {
            var cal = new TempCalculator ();
            var x = cal.ConvertKelvinToFahrenheit (input);

            x.Should ().Be (expectedResult);
        }

        [Theory (DisplayName = "เปลี่ยนค่า องศา Fahrenheit ให้เป็น Kelvin ได้สำเร็จ")]
        [InlineData (-297.67, 90)]
        public void ConvertFahrenheitToKelvinSuccess (double input, double expectedResult) {
            var cal = new TempCalculator ();
            var x = cal.ConvertFahrenheitToKelvin (input);

            x.Should ().Be (expectedResult);
        }

        [Theory (DisplayName = "เปลี่ยนค่า องศา celsius ให้เป็น Fahrenheit ได้สำเร็จ")]
        [InlineData (90, 363.15)]
        public void ConvertCelsiusToKelvinSuccess (double input, double expectedResult) {
            var cal = new TempCalculator ();
            var x = cal.ConvertCelsiusToKelvin (input);

            x.Should ().Be (expectedResult);
        }

        [Theory (DisplayName = "เปลี่ยนค่า Fahrenheit ให้เป็น celsiusได้สำเร็จ No.1")]
        [InlineData (5,-15.0)]
        [InlineData (14,-10.0)]
        [InlineData (41,5.00)]
        public void ConvertFahrenheitToCelsiusHomework (double input, double expectedResult) {
            var cal = new TempCalculator ();
            var x = cal.ConvertFahrenheitToCelsiusHomework (input);

            x.Should ().Be (expectedResult);
        }
        [Theory (DisplayName = "เปลี่ยนค่า องศา celsius ให้เป็น Fahrenheit ได้สำเร็จ NO.2")]
        [InlineData (32, 89.60)]
        [InlineData (50, 122.00)]
        [InlineData (14, 57.2000)]
        [InlineData (5.00, 41)]
        public void ConvertCelsiusToFahrenheitSuccessHomework (double input, double expectedResult) {
            var cal = new TempCalculator ();
            var x = cal.ConvertCelsiusToFahrenheitSuccessHomework (input);

            x.Should ().Be (expectedResult);
        }

    }
}