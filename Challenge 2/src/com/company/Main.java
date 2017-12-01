package com.company;

public class Main {

    public static void main(String[] args) {
        System.out.println(sumEvenFib(4000000));
    }

    public static int sumEvenFib(int high){
        int current = 0;
        int temp;
        int total = 0;
        int prev = 1;
        current = 2;
        while (current< high){
            if (current%2 == 0){
                total += current;
            }
            temp = current;
            current += prev;
            prev = temp;
        }
        return total;
    }
}
