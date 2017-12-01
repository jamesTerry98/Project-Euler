package com.company;

public class Main {

    public static void main(String[] args) {
        System.out.println(findLargestPallendrome());
    }

    public static int findLargestPallendrome(){
        int max = 0;
        int maxI = 1;
        for (int i = 999;i>maxI;i--){
            for (int j = 999;j>1;j--) {
                int ans = i* j;
                if (isPalindrome(ans)) {
                    if (max < ans) {
                        max = ans;
                        maxI = j;
                        break;
                    }
                }
            }
        }
        return max;
    }

    public static boolean isPalindrome(int ans){
        String str = Integer.toString(ans);
        String strRev = "";
        for (int i=str.length()-1;i>=0;i--){
            strRev = strRev + str.charAt(i);
        }
        if (str.equals(strRev))
            return true;
        else return false;
    }
}
