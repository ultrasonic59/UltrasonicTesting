﻿namespace UltrasonicTesting
{
    /// <summary>
    /// Класс описывающий физические свойства материалов.
    /// </summary>
    public class Material
    {
        /// <summary>
        /// Скорость распространения звука в материале. Размерность [м/с].
        /// </summary>
        public double SpeedOfSound { get; private set; }
        /// <summary>
        /// Плотность материала. Размерность [кг/м³].
        /// </summary>
        public double Density { get; private set; }
        /// <summary>
        /// Удельное акустическое сопротивление упругой среды. Размерность [Па*с/м].
        /// </summary>
        public double AcousticImpedance { get => SpeedOfSound*Density;}
        /// <summary>
        /// Пространственный коэффициент затухания. Размерность [Нп/м].
        /// </summary>
        public double FSPL { get; set; }
        public Material(double speedOfSound, double density, double fspl)
        {
            SpeedOfSound = speedOfSound;
            Density = density;
            FSPL = fspl;
        }
    }
}
