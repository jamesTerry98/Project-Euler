package com.company;

public class Main {

    public static void main(String[] args) {
        System.out.println(findXPrime(6));
    }

    public static int findXPrime(int x){
        int prime = 0;
        int checkNum = 1;
        while (prime < x){
            checkNum++;
            if (isPrime(checkNum))
                prime++;
        }
        return checkNum;
    }

    public static boolean isPrime(int num){
        for (int i = num/2; i>1; i--){
            if (num%i==0){
                return false;
            }
        }
        return true;
    }
}
