namespace Drawing;

 

 public class Line:Shape{
    public Point startPoint;
    public Point endPoint;


    public Line(){
        this.startPoint=new Point();
        this.endPoint=new Point();    }
 
 public Line(Point p1,Point p2,int w,string c):base(w,c){
    this.startPoint=p1;
    this.endPoint=p2;
 }
public override void Draw(){
   string data =string.Format("({0},{1}),({2},{3}),width={4},color={5}",startPoint.x,startPoint.y,endPoint.x,endPoint.y,width,color);
   Console.WriteLine(data);
}
 
 }