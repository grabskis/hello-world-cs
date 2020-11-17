using System;

public static class Math {
  public static int Add(int i, int j) {
//    var answer = 0;
    
    var answer = i + j;
    return answer;
  }

  public static int Multiply(int i, int j) {
    if (i == 0 || j == 0) return 0;

    var answer = 0;
    
    for (var x = 0; x < i; x += 1) {
      answer += j;
    }  

    return answer;
  }
}