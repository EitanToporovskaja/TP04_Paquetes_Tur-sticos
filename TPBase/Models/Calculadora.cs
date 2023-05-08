class Calculadora {
    public static double Calcular(double num1, double num2 , char operacion){
        switch(operacion){
            case '+':
            return Sumar(num1,num2);
            case '-':
            return Restar(num1,num2);
            case '*':
            return Multiplicar(num1,num2);
            case '/':
            return Dividir(num1,num2);
            case '^':
            return Potencia(num1,num2);
            default:
            return 0; 
        }
    }
    private static double Sumar(double num1, double num2)
    {
        return num1 + num2;
    }
    private static double Restar(double num1, double num2)
    {
        return num1 - num2;
    }
    private static double Multiplicar(double num1, double num2)
    {
        return num1 * num2;
    }
    private static double Dividir(double num1, double num2)
    {
        return num2 != 0 ? num1 / num2 : 0;
    }
    private static double Potencia(double num1, double num2)
    {
        return Math.Pow(num1,num2);//esto hace la potencia
    }
}