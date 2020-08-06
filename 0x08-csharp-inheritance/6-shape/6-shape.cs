using System;

///<summary>Shape.</summary>
class Shape
{
   ///<summary>Get area of shape</summary>
   public virtual int Area()
   {
       throw new System.NotImplementedException("Area() is not implemented");
   }
}

///<summary>Rectangle.</summary>
class Rectangle:Shape
{
   private int width;
   private int height;

   ///<summary>Get/Set width</summary>
   public int Width
   {
       get
       {
         return (width);
       }

       set
       {
           if (value < 0)
           {
               throw new System.ArgumentException("Width must be greater than or equal to 0");
           }
           else
           {
               width = value;
           }
       }
   }
   ///<summary>Get/Set height</summary>
   public int Height
   {
       get
       {
         return (height);
       }

       set
       {
           if (value < 0)
           {
               throw new System.ArgumentException("Height must be greater than or equal to 0");
           }
           else
           {
               height = value;
           }
       }
   }
}
