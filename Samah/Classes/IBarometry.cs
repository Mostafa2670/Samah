using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// ساخت فورک تستی
namespace Samah.Classes
{
    /// <summary>
    /// IBarometry Interface Is Top Level Interface For Resolve Barometry Problem
    /// </summary>
    
    /// <remarks>
    /// This interface is responsible for the communication between actual classes and implemented codes.
    /// </remarks>
    interface IBarometry
    {
        /// <summary>
        /// توضیحات مختصر از تابع در یک خط داده شود
        /// </summary>
        /// <param name="message_1"> توضیحات مربوط به پارامتر داده شود.</param>
        /// <param name="nohe_message"> nohe_message description for s goes here.</param>
        /// <param name="Lng"> Lng description for s goes here.</param>
        /// <param name="Lat"> Lat description for s goes here.</param>
        /// برای همه ی گروه ها مستند سازی شود
        string Group_1(string message_1, int nohe_message, int Lng, int Lat);
        string Group_2_Lat(int Lat);
        string Group_2_Lng(int Lng);
        string Group_3(int date);
        double Group_4_Altitude(double data);
        double Group_4_Pressure(double data);
        int Text_Group_1_Line(double data);///پیدا کردن لاین هواسنجی/////
        int Text_Group_1_Grabad(int data);///جهت مشخص کردن گرا باد////
        int Text_Group_1_Speed(int data);////////برای سرعت باد///
        double Text_Group_2_Temperatures(int data);
        double Text_Group_2_Weight(int data);
    }
}
