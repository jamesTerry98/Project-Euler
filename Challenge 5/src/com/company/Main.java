package com.company;

import java.util.ArrayList;

public class Main {
    public static ArrayList<Integer> list = new ArrayList();
    public static int total = 1;

    public static void main(String[] args) {
        System.out.println(lcm(20));
    }

    public static int lcm(int num) {
        for (int i = num; i > 0; i--) {
                split(i);
        }
        for (int j = list.size() - 1; j >= 0; j--) {
                total = total * list.get(j);
        }
        return total;
    }

    public static ArrayList<Integer> split(int num) {
        for (int i = num / 2; i > 1; i--) {
                if (num % i == 0) {
                    list.add(num / i);
                    split(i);
                    break;
                }
            }
        return list;
    }

    public static boolean isPrime(int num) {
        for (int i = num-1; i>1; i--){
            if (num%i==0){
                return false;
            }
        }
        return true;
    }
}