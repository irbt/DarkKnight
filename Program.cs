using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;

/**
 * Auto-generated code below aims at helping you parse
 * the standard input according to the problem statement.
 **/
class Player{
    static void Main(string[] args)
    {
        //string[] inputs;
        //inputs = Console.ReadLine().Split(' ');
        int W = 25; // width of the building.
        int H = 32; // height of the building.
        int N = 50; // maximum number of turns before game over.
        //inputs = Console.ReadLine().Split(' ');
        int X0 = 22;
        int Y0 = 29;

        
        int count = 0;

        // game loop
        
        
            int PX =0;
            int PY =0;
           
            int maxX = W-1;
            int minX = 0;
            int maxY = H-1;
            int minY = 0;


            Console.Error.WriteLine($"Dim immeuble W= {W} H ={H} N={N}");
        while (true)
        {
            Console.WriteLine("Bombdir = ");
            string bombDir = Console.ReadLine(); 
            // the direction of the bombs from batman's current location (U, UR, R, DR, D, DL, L or UL)
            //Console.Error.WriteLine("Debug messages...");
            int X  ;
            int Y ;
            

            if (count ==0){
                PX = X0;
                PY = Y0;
            }

           
           
               switch (bombDir){
                
                case "UR":
                    minX = PX+1;
                    maxY = PY-1;

                    Console.Error.WriteLine($"début boucle UR... PX =  {PX} | PY =  {PY} | Count =  {count} ");
                    Console.Error.WriteLine($"début boucle UR... minX={minX}| maxX={maxX} | minY={minY}| maxY={maxY} Count =  {count} ");
                    X = PX + Math.Abs((PX-maxX)/2) ;
                    Y = PY - Math.Abs((PY-minY)/2);


                    Console.WriteLine($"{X} {Y}");
                    
                    PX =X;
                    PY = Y;
                    Console.Error.WriteLine($"fin boucle UR... PX =  {PX} | PY =  {PY} | Count =  {count} ");
                    Console.Error.WriteLine($"fin boucle UR... minX={minX}| maxX={maxX} | minY={minY}| maxY={maxY} Count =  {count} ");
                    count ++;
                    break;
                
                case "U":
                    minX = PX;
                    maxX = PX;
                    maxY = PY-1;
                    
                    Console.Error.WriteLine($"début boucle U... PX =  {PX} | PY =  {PY} | Count =  {count} ");
                    Console.Error.WriteLine($"début boucle U... minX={minX}| maxX={maxX} | minY={minY}| maxY={maxY} Count =  {count} ");
                    
                    X= PX;
                    Y = PY - Math.Abs(PY -minY)/2-1;

                    

                    Console.WriteLine($"{X} {Y}");
                                                           
                    
                    PX =X;
                    PY = Y;
                    
                    Console.Error.WriteLine($"fin boucle U... PX =  {PX} | PY =  {PY} | Count =  {count} ");
                    Console.Error.WriteLine($"fin boucle U... minX={minX}| maxX={maxX} | minY={minY}| maxY={maxY} Count =  {count} ");
                    count ++;
                    break;

                case "R":
                    minX = PX+1;
                    maxY = PY;
                    minY = PY;

                    Console.Error.WriteLine($"début boucle R... PX =  {PX} | PY =  {PY} | Count =  {count} ");
                    Console.Error.WriteLine($"début boucle R... minX={minX}| maxX={maxX} | minY={minY}| maxY={maxY} Count =  {count} ");
                
                    X = PX + Math.Abs(PX-maxX)/2;
                    Y= PY;

                    if(X == PX){
                    X = PX +( Math.Abs(PX-maxX)/2)+1;
                    }
                    Console.WriteLine($"{X} {Y}");

                    
                    PX =X;
                    PY = Y;
                    
                    Console.Error.WriteLine($"fin boucle R... PX =  {PX} | PY =  {PY} | Count =  {count} ");
                    Console.Error.WriteLine($"fin boucle R... minX={minX}| maxX={maxX} | minY={minY}| maxY={maxY} Count =  {count} ");
                    count ++;
                    break;

                case "DR":
                    minX = PX+1;
                    minY = PY+1;

                    Console.Error.WriteLine($"début boucle DR... PX =  {PX} | PY =  {PY} | Count =  {count} ");
                    Console.Error.WriteLine($"début boucle DR... minX={minX}| maxX={maxX} | minY={minY}| maxY={maxY} Count =  {count} ");

                    X = PX + Math.Abs(PX-maxX)/2;
                    Y = PY + Math.Abs(PY-maxY)/2;
                    if (X == PX){
                         X = X+1;
                    }
                    if (Y == PY){
                         Y = Y+1;
                    }
                    if((Math.Abs(PX-maxX)/2)==1){
                        X = PX +2;
                    }
                    if((Math.Abs(PY-maxY)/2)==1){
                        Y = PY +2;
                    }
                    Console.WriteLine($"{X} {Y}");

                    
                    PX =X;
                    PY = Y;
                    
                    Console.Error.WriteLine($"fin boucle DR... PX =  {PX} | PY =  {PY} | Count =  {count} ");
                    Console.Error.WriteLine($"fin boucle DR... minX={minX}| maxX={maxX} | minY={minY}| maxY={maxY} Count =  {count} ");
                    count ++;
                    break;

                case "D":
                    minX = PX;
                    maxX = PX;
                    minY = PY+1;

                    Console.Error.WriteLine($"début boucle D... PX =  {PX} | PY =  {PY} | Count =  {count} ");
                    Console.Error.WriteLine($"début boucle D... minX={minX}| maxX={maxX} | minY={minY}| maxY={maxY} Count =  {count} ");
                    
                    X = PX;
                    Y = PY + Math.Abs(PY-maxY)/2;
                    // si Y est le même que la valeur précédente
                    if (Y == PY){
                         Y = Y+1;
                    }
                    Console.WriteLine($"{X} {Y}");

                    
                    PX =X;
                    PY = Y;
                    
                    Console.Error.WriteLine($"fin boucle D... PX =  {PX} | PY =  {PY} | Count =  {count} ");
                    Console.Error.WriteLine($"fin boucle D... minX={minX}| maxX={maxX} | minY={minY}| maxY={maxY} Count =  {count} ");
                    count ++;
                    
                    break;

                case "DL":
                    maxX = PX-1;
                    minY = PY+1;

                    Console.Error.WriteLine($"début boucle DL... PX =  {PX} | PY =  {PY} | Count =  {count} ");
                    Console.Error.WriteLine($"début boucle DL... minX={minX}| maxX={maxX} | minY={minY}| maxY={maxY} Count =  {count} ");

                    X = PX - (Math.Abs(PX-minX)/2);
                    Y = PY + (Math.Abs(PY-maxY)/2);
                    Console.WriteLine($"{X} {Y}");
                    
                    PX =X;
                    PY = Y;
                    
                    Console.Error.WriteLine($"fin boucle DL... PX =  {PX} | PY =  {PY} | Count =  {count} ");
                    Console.Error.WriteLine($"fin boucle DL... minX={minX}| maxX={maxX} | minY={minY}| maxY={maxY} Count =  {count} ");
                    count ++;
                    break;

                case "L":
                    maxX = PX-1;
                    
                    maxY = PY;
                    minY = PY;

                    Console.Error.WriteLine($"début boucle L... PX =  {PX} | PY =  {PY} | Count =  {count} ");
                    Console.Error.WriteLine($"début boucle L... minX={minX}| maxX={maxX} | minY={minY}| maxY={maxY} Count =  {count} ");

                   
                    if(PX == 1){
                        X = 0;
                    } else{
                       X = PX - Math.Abs(PX-minX)/2;
                    }
                   Y = PY;
                   
                    PX =X;
                    PY = Y;
                    
                    Console.Error.WriteLine($"fin boucle L... PX =  {PX} | PY =  {PY} | Count =  {count} ");
                    Console.Error.WriteLine($"fin boucle L... minX={minX}| maxX={maxX} | minY={minY}| maxY={maxY} Count =  {count} ");
                    count ++;
                    break;

                case "UL":
                    maxX = PX-1;
                    maxY = PY-1;

                    Console.Error.WriteLine($"début boucle UL... PX =  {PX} | PY =  {PY} | Count =  {count} ");
                    Console.Error.WriteLine($"début boucle UL... minX={minX}| maxX={maxX} | minY={minY}| maxY={maxY} Count =  {count} ");

                    X = PX - Math.Abs(PX-minX)/2;
                    Y = PY - Math.Abs(PY-minY)/2; 

                    if(X == PX){
                        X = PX-1;
                    } 
                    if(Y == PY){
                        Y = PY-1;
                    } 

                    if (Math.Abs(PX-minX)/2 ==1 ){
                        X = PX-1;
                        if(X<0){
                            X=0;
                        }
                    }
                    if (Math.Abs(PY-minY)/2 ==1 ){
                        Y = PX -1;
                        if(Y<0){
                            Y=0;
                        }
                    }
                    Console.WriteLine($"{X} {Y}");

                    PX =X;
                    PY = Y;
                    
                    Console.Error.WriteLine($"fin boucle UL... PX =  {PX} | PY =  {PY} | Count =  {count} ");
                    Console.Error.WriteLine($"fin boucle UL... minX={minX}| maxX={maxX} | minY={minY}| maxY={maxY} Count =  {count} ");
                    count ++;
                    break;
                
                default:
                
                
                
                count ++;
                break;
            }
            // Write an action using Console.WriteLine()
            // To debug: Console.Error.WriteLine("Debug messages...");

            
            
   }
}}