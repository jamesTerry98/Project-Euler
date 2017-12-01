package com.company;

public class Main {

    public static void main(String[] args) {
	    int range = 100;
	    System.out.println(sum(range)-squareSum(range));
    }

    static int squareSum(int range){
        int total = 0;
        for (int i = range; i>0; i--){
            total += i*i;
        }
        return total;
    }

    static int sum(int range){
        return (int)Math.pow(((range*(range+1))/2),2);
    }
}
