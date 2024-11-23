// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HelloWorld

{
    public static (double,double) linearRegression(double[] X,double[] Y,double alpha=0.001,int iterations=100000){
        double theta0=0,theta1=1;
        int m=Y.Length;
        for(int iteration=1;iteration<=iterations;iteration++){
            double[] predictions=new double[m];
            for(int i=0;i<m;i++){
                predictions[i]=theta0+theta1*X[i];
            }
            double sum0=0,sum1=0;
            for(int i=0;i<m;i++){
                sum0+=Y[i]-predictions[i];
                sum1+=(Y[i]-predictions[i])*X[i];
            }
            double dTheta0=(-2.0/m)*alpha*sum0;
            double dTheta1=(-2.0/m)*alpha*sum1;
            theta0-=dTheta0;
            theta1-=dTheta1;
        }
        return (theta0,theta1);
    }
    public static void Main(string[] args)
    {
           double[] X={1,2,3,4,5};
           double[] Y=new double[X.Length];
           for(int i=0;i<X.Length;i++){
               Y[i]=3+2*X[i];
           }
           double theta0,theta1;
           (theta0,theta1)=linearRegression(X,Y);
           Console.Write($"X:\t");
           for(int i=0;i<X.Length;i++){Console.Write($" {X[i]}");}
           Console.Write("\nY:\t");
           for(int i=0;i<Y.Length;i++){Console.Write($" {Y[i]}");}
           Console.Write($"\nFunction[determined by linear regression]:\tf(x)={theta0}+{theta1}*x");
    }
}
