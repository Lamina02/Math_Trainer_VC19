using System;

namespace Math_Trainer_VC19
{
    class Handler
    {
        protected static bool AdditionFlag;
        protected static bool SubtractionFlag;
        protected static bool MultiplicationFlag;
        protected static bool DivisionFlag;

        
        // setters
        public static void set_UsingAddition(bool flag)
        {
            AdditionFlag = flag;
        }

        public static void set_UsingSubtraction(bool flag)
        {
            SubtractionFlag = flag;
        }

        public static void set_UsingMultiplication(bool flag)
        {
            MultiplicationFlag = flag;
        }

        public static void set_UsingDivision(bool flag)
        {
            DivisionFlag = flag;
        }


        // getters
        public static bool get_UsingAddition()
        {
            return AdditionFlag;
        }

        public static bool get_UsingSubtraction()
        {
            return SubtractionFlag;
        }

        public static bool get_UsingMultiplication()
        {
            return MultiplicationFlag;
        }

        public static bool get_UsingDivision()
        {
            return DivisionFlag;
        }
    }
}
