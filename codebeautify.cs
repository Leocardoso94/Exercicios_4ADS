using System;

public class Program {
 public static void Main() {
  //exercicio1();
  //exercicio2();
  //exercicio3();
  exercicio4(10);
 }

 public static void exercicio1() {
  int soma = 0;

  for (int i = 1; i <= 100; i++) {
   soma += i;
  }

  Console.WriteLine(soma);
 }

 public static void exercicio2() {
  for (int i = 1; i <= 200; i++) {
   if (i % 7 == 0) {
    Console.WriteLine(i);
   }
  }
 }

 public static void exercicio3() {
  for (int i = 1; i <= 100; i++) {
   if (i % 4 == 0) {
    Console.WriteLine(i);
   }
  }
 }

 public static double exercicio4(int x) {
  double s = 0;

  for (int i = 1; i <= 20; i++) {
   if (i % 2 == 0) {
    s -= x / i;
   } else {
    s += x / i;
   }
  }

  Console.WriteLine(s);

  return s;
 }
}