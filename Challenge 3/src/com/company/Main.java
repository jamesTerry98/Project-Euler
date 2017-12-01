package com.company;

public class Main {
public static long largestPrime = 2;
    public static void main(String[] args) {
        System.out.println(primeFactorSearch(600851475143L));
    }

    public static long primeFactorSearch(long number){
        long max = 0;
        for (long i = 2; i < number/2;i++){
            if (isItAFactor(i,number) && isItPrime(i)){
                max = i;
            }
        }
        return max;
    }

    public static boolean isItAFactor(long i, long number){
        if (number%i == 0) return true;
        else return false;
    }

    public static boolean isItPrime(long number) {
        for (long i = 2; i<number/2;i++){
            if (number%i==0) {
                return false;
            }
        }
        return true;
    }
}
