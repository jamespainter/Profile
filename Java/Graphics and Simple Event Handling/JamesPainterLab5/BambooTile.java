import java.awt.*;
import java.awt.event.*;
import javax.swing.*;
import java.awt.font.*;
import java.awt.geom.Ellipse2D;
import java.awt.geom.Point2D;
import java.awt.geom.QuadCurve2D;
import java.awt.geom.Rectangle2D;
 


public class BambooTile extends RankTile
{
	
	public BambooTile(int rank)
	{
		super(rank); 
		setToolTipText(toString());
	}
	
	public void paintComponent(Graphics g)
	{
	 	super.paintComponent(g);
	 	Color green = Color.decode("#00CD00");
	 	Color blue = Color.BLUE;
	 	Color red = Color.decode("#B0171F");
	 	Color white = Color.white; 
	 	Graphics2D	g2 = (Graphics2D)g;
	 	//Polygon p = new Polygon();
	 	//Ellipse2D elip = new Ellipse2D.Double(130.0, 190.0, 30.0, 10.0);
	 	//Rectangle2D rect = new Rectangle2D.Double(139, 175, 10, 40);
	 	QuadCurve2D qc1 = new QuadCurve2D.Float();
	 	QuadCurve2D qc2 = new QuadCurve2D.Float();
	 	//q.setCurve(50, 100, 110, 110, 100, 150);
	 	//new Ellipse2D.Double(this.getWidth()/2, (this.getHeight()/2)+25, 30.0, 10.0);
	 	//Ellipse2D e[] = new Ellipse2D[4];
	 	
	 	switch(super.rank)
		{
			case 2:
				
//				//Rectangle2D r[]= new Rectangle2D[1];
//		 		e[0] = new Ellipse2D.Double(130.0, 173.0, 30.0, 10.0);
//		 		e[1] = new Ellipse2D.Double(130.0, 190.0, 30.0, 10.0);
//		 		e[2] = new Ellipse2D.Double(130.0, 210.0, 30.0, 10.0);
//		 		//r[3] = new Rectangle2D.Double(140, 175, 10, 40);
//		 		g.setColor(green);
//		 		for(Ellipse2D c: e)
//		 		   g2.fill(c);
		 		//qc1.setCurve(130, 215, 160, 195, 130, 175);
				//qc2.setCurve(136, 215, 60, 95, 133, 175);
				//g.setColor(green);
				//g2.draw(qc1);
				//g.setColor(Color.black);
				//g2.draw(qc2);
			
				
			// Top blue 
				g.setColor(Color.BLUE);
				g2.fill(new Ellipse2D.Double(133.0, 108.0, 25.0, 10.0));
				g2.fill(new Ellipse2D.Double(133.0, 142.0, 25.0, 10.0));
				g2.fill(new Rectangle2D.Double(141, 110, 10, 40));
				g.setColor(Color.white);
				g.drawLine(147, 115, 147, 145);
				g.setColor(Color.blue);
				g2.fill(new Ellipse2D.Double(133.0, 125.0, 25.0, 10.0));	
			// bottom Green 
				g.setColor(green);
				g2.fill(new Ellipse2D.Double(133.0, 153.0, 25.0, 10.0));
				g2.fill(new Ellipse2D.Double(133.0, 187.0, 25.0, 10.0));
				g2.fill(new Rectangle2D.Double(141, 153, 10, 43));
				g.setColor(Color.white);
				g.drawLine(147, 160, 147, 190);
				g.setColor(green);
				g2.fill(new Ellipse2D.Double(133.0, 170.0, 25.0, 10.0));
				
				break;
			case 3:
			// Top blue 
				g.setColor(Color.BLUE);
				g2.fill(new Ellipse2D.Double(133.0, 108.0, 25.0, 10.0));
				g2.fill(new Ellipse2D.Double(133.0, 142.0, 25.0, 10.0));
				g2.fill(new Rectangle2D.Double(141, 110, 10, 40));
				g.setColor(Color.white);
				g.drawLine(147, 115, 147, 145);
				g.setColor(Color.blue);
				g2.fill(new Ellipse2D.Double(133.0, 125.0, 25.0, 10.0));
				
			// bottom left Green 
				g.setColor(green);
				g2.fill(new Ellipse2D.Double(103.0, 153.0, 25.0, 10.0));
				g2.fill(new Ellipse2D.Double(103.0, 187.0, 25.0, 10.0));
				g2.fill(new Rectangle2D.Double(111, 153, 10, 43));
				g.setColor(Color.white);
				g.drawLine(117, 160, 117, 190);
				g.setColor(green);
				g2.fill(new Ellipse2D.Double(103.0, 170.0, 25.0, 10.0));
			// bottom Right Green 
				g.setColor(green);
				g2.fill(new Ellipse2D.Double(163.0, 153.0, 25.0, 10.0));
				g2.fill(new Ellipse2D.Double(163.0, 187.0, 25.0, 10.0));
				g2.fill(new Rectangle2D.Double(171, 153, 10, 43));
				g.setColor(Color.white);
				g.drawLine(177, 160, 177, 190);
				g.setColor(green);
				g2.fill(new Ellipse2D.Double(163.0, 170.0, 25.0, 10.0));	
				break;
			case 4:
			// 1rst row left blue 
				g.setColor(Color.BLUE);
				g2.fill(new Ellipse2D.Double(103.0, 108.0, 25.0, 10.0));
				g2.fill(new Ellipse2D.Double(103.0, 142.0, 25.0, 10.0));
				g2.fill(new Rectangle2D.Double(111, 110, 10, 40));
				g.setColor(Color.white);
				g.drawLine(117, 115, 117, 145);
				g.setColor(Color.blue);
				g2.fill(new Ellipse2D.Double(103.0, 125.0, 25.0, 10.0));
			
			// 1rst row right green 
				g.setColor(green);
				g2.fill(new Ellipse2D.Double(163.0, 108.0, 25.0, 10.0));
				g2.fill(new Ellipse2D.Double(163.0, 142.0, 25.0, 10.0));
				g2.fill(new Rectangle2D.Double(171, 110, 10, 40));
				g.setColor(Color.white);
				g.drawLine(177, 115, 177, 145);
				g.setColor(green);
				g2.fill(new Ellipse2D.Double(163.0, 125.0, 25.0, 10.0));
				
			// 2nd row left green 
				g.setColor(green);
				g2.fill(new Ellipse2D.Double(103.0, 153.0, 25.0, 10.0));
				g2.fill(new Ellipse2D.Double(103.0, 187.0, 25.0, 10.0));
				g2.fill(new Rectangle2D.Double(111, 153, 10, 43));
				g.setColor(Color.white);
				g.drawLine(117, 160, 117, 190);
				g.setColor(green);
				g2.fill(new Ellipse2D.Double(103.0, 170.0, 25.0, 10.0));
			
			// 2nd Right blue 
				g.setColor(Color.blue);
				g2.fill(new Ellipse2D.Double(163.0, 153.0, 25.0, 10.0));
				g2.fill(new Ellipse2D.Double(163.0, 187.0, 25.0, 10.0));
				g2.fill(new Rectangle2D.Double(171, 153, 10, 43));
				g.setColor(Color.white);
				g.drawLine(177, 160, 177, 190);
				g.setColor(Color.blue);
				g2.fill(new Ellipse2D.Double(163.0, 170.0, 25.0, 10.0));
				break;
			case 5:  
				// 1rst row left green 
				g.setColor(green);
				g2.fill(new Ellipse2D.Double(93.0, 108.0, 25.0, 10.0));
				g2.fill(new Ellipse2D.Double(93.0, 142.0, 25.0, 10.0));
				g2.fill(new Rectangle2D.Double(101, 110, 10, 40));
				g.setColor(Color.white);
				g.drawLine(107, 115, 107, 145);
				g.setColor(green);
				g2.fill(new Ellipse2D.Double(93.0, 125.0, 25.0, 10.0));
				
				// 2nd row left blue 
				g.setColor(Color.blue);
				g2.fill(new Ellipse2D.Double(93.0, 153.0, 25.0, 10.0));
				g2.fill(new Ellipse2D.Double(93.0, 187.0, 25.0, 10.0));
				g2.fill(new Rectangle2D.Double(101, 153, 10, 43));
				g.setColor(Color.white);
				g.drawLine(107, 160, 107, 190);
				g.setColor(Color.blue);
				g2.fill(new Ellipse2D.Double(93.0, 170.0, 25.0, 10.0));
				
				// Middle red 
				g.setColor(red);
				g2.fill(new Ellipse2D.Double(133.0, 128.0, 25.0, 10.0));
				g2.fill(new Ellipse2D.Double(133.0, 162.0, 25.0, 10.0));
				g2.fill(new Rectangle2D.Double(141, 128, 10, 43));
				g.setColor(Color.white);
				g.drawLine(147, 135, 147, 165);
				g.setColor(red);
				g2.fill(new Ellipse2D.Double(133.0, 145.0, 25.0, 10.0));
				
				// 1rst row left blue 
				g.setColor(Color.blue);
				g2.fill(new Ellipse2D.Double(173.0, 108.0, 25.0, 10.0));
				g2.fill(new Ellipse2D.Double(173.0, 142.0, 25.0, 10.0));
				g2.fill(new Rectangle2D.Double(181, 110, 10, 40));
				g.setColor(Color.white);
				g.drawLine(187, 115, 187, 145);
				g.setColor(Color.blue);
				g2.fill(new Ellipse2D.Double(173.0, 125.0, 25.0, 10.0));
				
				// 2nd row left green 
				g.setColor(green);
				g2.fill(new Ellipse2D.Double(173.0, 153.0, 25.0, 10.0));
				g2.fill(new Ellipse2D.Double(173.0, 187.0, 25.0, 10.0));
				g2.fill(new Rectangle2D.Double(181, 153, 10, 43));
				g.setColor(Color.white);
				g.drawLine(187, 160, 187, 190);
				g.setColor(green);
				g2.fill(new Ellipse2D.Double(173.0, 170.0, 25.0, 10.0));
				break;
			case 6: 
				// 1rst row left green 
				g.setColor(green);
				g2.fill(new Ellipse2D.Double(93.0, 108.0, 25.0, 10.0));
				g2.fill(new Ellipse2D.Double(93.0, 142.0, 25.0, 10.0));
				g2.fill(new Rectangle2D.Double(101, 110, 10, 40));
				g.setColor(Color.white);
				g.drawLine(107, 115, 107, 145);
				g.setColor(green);
				g2.fill(new Ellipse2D.Double(93.0, 125.0, 25.0, 10.0));
				
				// 1rst row left 2 green 
				g.setColor(green);
				g2.fill(new Ellipse2D.Double(133.0, 108.0, 25.0, 10.0));
				g2.fill(new Ellipse2D.Double(133.0, 142.0, 25.0, 10.0));
				g2.fill(new Rectangle2D.Double(141, 110, 10, 40));
				g.setColor(Color.white);
				g.drawLine(147, 115, 147, 145);
				g.setColor(green);
				g2.fill(new Ellipse2D.Double(133.0, 125.0, 25.0, 10.0));
				
				// 1rst row left 3 green 
				g.setColor(green);
				g2.fill(new Ellipse2D.Double(173.0, 108.0, 25.0, 10.0));
				g2.fill(new Ellipse2D.Double(173.0, 142.0, 25.0, 10.0));
				g2.fill(new Rectangle2D.Double(181, 110, 10, 40));
				g.setColor(Color.white);
				g.drawLine(187, 115, 187, 145);
				g.setColor(green);
				g2.fill(new Ellipse2D.Double(173.0, 125.0, 25.0, 10.0));
				
				// 2nd row left blue 
				g.setColor(Color.blue);
				g2.fill(new Ellipse2D.Double(93.0, 153.0, 25.0, 10.0));
				g2.fill(new Ellipse2D.Double(93.0, 187.0, 25.0, 10.0));
				g2.fill(new Rectangle2D.Double(101, 153, 10, 43));
				g.setColor(Color.white);
				g.drawLine(107, 160, 107, 190);
				g.setColor(Color.blue);
				g2.fill(new Ellipse2D.Double(93.0, 170.0, 25.0, 10.0));
				
				// 2nd row left 2 blue 
				g.setColor(Color.blue);
				g2.fill(new Ellipse2D.Double(133.0, 153.0, 25.0, 10.0));
				g2.fill(new Ellipse2D.Double(133.0, 187.0, 25.0, 10.0));
				g2.fill(new Rectangle2D.Double(141, 153, 10, 43));
				g.setColor(Color.white);
				g.drawLine(147, 160, 147, 190);
				g.setColor(Color.blue);
				g2.fill(new Ellipse2D.Double(133.0, 170.0, 25.0, 10.0));
				
				// 2nd row left 3 blue 
				g.setColor(Color.blue);
				g2.fill(new Ellipse2D.Double(173.0, 153.0, 25.0, 10.0));
				g2.fill(new Ellipse2D.Double(173.0, 187.0, 25.0, 10.0));
				g2.fill(new Rectangle2D.Double(181, 153, 10, 43));
				g.setColor(Color.white);
				g.drawLine(187, 160, 187, 190);
				g.setColor(Color.blue);
				g2.fill(new Ellipse2D.Double(173.0, 170.0, 25.0, 10.0));
				
				break;
			case 7: 
				// Top Middle red 
				g.setColor(red);
				g2.fill(new Ellipse2D.Double(133.0, 78.0, 25.0, 10.0));
				g2.fill(new Ellipse2D.Double(133.0, 112.0, 25.0, 10.0));
				g2.fill(new Rectangle2D.Double(141, 78, 10, 43));
				g.setColor(Color.white);
				g.drawLine(147, 85, 147, 115);
				g.setColor(red);
				g2.fill(new Ellipse2D.Double(133.0, 95.0, 25.0, 10.0));
				
				// 1rst row left green 
				g.setColor(green);
				g2.fill(new Ellipse2D.Double(93.0, 123.0, 25.0, 10.0));
				g2.fill(new Ellipse2D.Double(93.0, 157.0, 25.0, 10.0));
				g2.fill(new Rectangle2D.Double(101, 125, 10, 40));
				g.setColor(Color.white);
				g.drawLine(107, 130, 107, 160);
				g.setColor(green);
				g2.fill(new Ellipse2D.Double(93.0, 140.0, 25.0, 10.0));
				
				// 1rst row left 2 green 
				g.setColor(green);
				g2.fill(new Ellipse2D.Double(133.0, 123.0, 25.0, 10.0));
				g2.fill(new Ellipse2D.Double(133.0, 157.0, 25.0, 10.0));
				g2.fill(new Rectangle2D.Double(141, 125, 10, 40));
				g.setColor(Color.white);
				g.drawLine(147, 130, 147, 160);
				g.setColor(green);
				g2.fill(new Ellipse2D.Double(133.0, 140.0, 25.0, 10.0));
				
				// 1rst row left 3 green 
				g.setColor(green);
				g2.fill(new Ellipse2D.Double(173.0, 123.0, 25.0, 10.0));
				g2.fill(new Ellipse2D.Double(173.0, 157.0, 25.0, 10.0));
				g2.fill(new Rectangle2D.Double(181, 125, 10, 40));
				g.setColor(Color.white);
				g.drawLine(187, 130, 187, 160);
				g.setColor(green);
				g2.fill(new Ellipse2D.Double(173.0, 140.0, 25.0, 10.0));
				
				// 2nd row left blue 
				g.setColor(Color.blue);
				g2.fill(new Ellipse2D.Double(93.0, 168.0, 25.0, 10.0));
				g2.fill(new Ellipse2D.Double(93.0, 202.0, 25.0, 10.0));
				g2.fill(new Rectangle2D.Double(101, 168, 10, 43));
				g.setColor(Color.white);
				g.drawLine(107, 175, 107, 205);
				g.setColor(Color.blue);
				g2.fill(new Ellipse2D.Double(93.0, 185.0, 25.0, 10.0));
				
				// 2nd row left 2 blue 
				g.setColor(Color.blue);
				g2.fill(new Ellipse2D.Double(133.0, 168.0, 25.0, 10.0));
				g2.fill(new Ellipse2D.Double(133.0, 202.0, 25.0, 10.0));
				g2.fill(new Rectangle2D.Double(141, 168, 10, 43));
				g.setColor(Color.white);
				g.drawLine(147, 175, 147, 205);
				g.setColor(Color.blue);
				g2.fill(new Ellipse2D.Double(133.0, 185.0, 25.0, 10.0));
				
				// 2nd row left 3 blue 
				g.setColor(Color.blue);
				g2.fill(new Ellipse2D.Double(173.0, 168.0, 25.0, 10.0));
				g2.fill(new Ellipse2D.Double(173.0, 202.0, 25.0, 10.0));
				g2.fill(new Rectangle2D.Double(181, 168, 10, 43));
				g.setColor(Color.white);
				g.drawLine(187, 175, 187, 205);
				g.setColor(Color.blue);
				g2.fill(new Ellipse2D.Double(173.0, 185.0, 25.0, 10.0));
				break;
			case 8:  
				// 1rst row left green 
				g.setColor(green);
				g2.fill(new Ellipse2D.Double(93.0, 78.0, 25.0, 10.0));
				g2.fill(new Ellipse2D.Double(93.0, 112.0, 25.0, 10.0));
				g2.fill(new Rectangle2D.Double(101, 80, 10, 40));
				g.setColor(Color.white);
				g.drawLine(107, 85, 107, 115);
				g.setColor(green);
				g2.fill(new Ellipse2D.Double(93.0, 95.0, 25.0, 10.0));
				
				// 1rst row left 2 green 
				g.setColor(green);
				g2.fill(new Ellipse2D.Double(133.0, 78.0, 25.0, 10.0));
				g2.fill(new Ellipse2D.Double(133.0, 112.0, 25.0, 10.0));
				g2.fill(new Rectangle2D.Double(141, 80, 10, 40));
				g.setColor(Color.white);
				g.drawLine(147, 85, 147, 115);
				g.setColor(green);
				g2.fill(new Ellipse2D.Double(133.0, 95.0, 25.0, 10.0));
				
				// 1rst row left 3 green 
				g.setColor(green);
				g2.fill(new Ellipse2D.Double(173.0, 78.0, 25.0, 10.0));
				g2.fill(new Ellipse2D.Double(173.0, 112.0, 25.0, 10.0));
				g2.fill(new Rectangle2D.Double(181, 80, 10, 40));
				g.setColor(Color.white);
				g.drawLine(187, 85, 187, 115);
				g.setColor(green);
				g2.fill(new Ellipse2D.Double(173.0, 95.0, 25.0, 10.0));
				
				// 2nd row left red 
				g.setColor(red);
				g2.fill(new Ellipse2D.Double(110.0, 124.0, 25.0, 10.0));
				g2.fill(new Ellipse2D.Double(110.0, 158.0, 25.0, 10.0));
				g2.fill(new Rectangle2D.Double(118, 124, 10, 43));
				g.setColor(Color.white);
				g.drawLine(124, 131, 124, 161);
				g.setColor(red);
				g2.fill(new Ellipse2D.Double(110.0, 141.0, 25.0, 10.0));
				// 2nd row right red 
				g.setColor(red);
				g2.fill(new Ellipse2D.Double(156.0, 124.0, 25.0, 10.0));
				g2.fill(new Ellipse2D.Double(156.0, 158.0, 25.0, 10.0));
				g2.fill(new Rectangle2D.Double(164, 124, 10, 43));
				g.setColor(Color.white);
				g.drawLine(170, 131, 169, 162);
				g.setColor(red);
				g2.fill(new Ellipse2D.Double(156.0, 141.0, 25.0, 10.0));
				
				// 3rd row 1 blue
				g.setColor(Color.blue);
				g2.fill(new Ellipse2D.Double(93.0, 168.0, 25.0, 10.0));
				g2.fill(new Ellipse2D.Double(93.0, 202.0, 25.0, 10.0));
				g2.fill(new Rectangle2D.Double(101, 168, 10, 43));
				g.setColor(Color.white);
				g.drawLine(107, 175, 107, 205);
				g.setColor(Color.blue);
				g2.fill(new Ellipse2D.Double(93.0, 185.0, 25.0, 10.0));
				
				// 3rd row left 2 blue 
				g.setColor(Color.blue);
				g2.fill(new Ellipse2D.Double(133.0, 168.0, 25.0, 10.0));
				g2.fill(new Ellipse2D.Double(133.0, 202.0, 25.0, 10.0));
				g2.fill(new Rectangle2D.Double(141, 168, 10, 43));
				g.setColor(Color.white);
				g.drawLine(147, 175, 147, 205);
				g.setColor(Color.blue);
				g2.fill(new Ellipse2D.Double(133.0, 185.0, 25.0, 10.0));
				
				// 3rd row left 3 blue 
				g.setColor(Color.blue);
				g2.fill(new Ellipse2D.Double(173.0, 168.0, 25.0, 10.0));
				g2.fill(new Ellipse2D.Double(173.0, 202.0, 25.0, 10.0));
				g2.fill(new Rectangle2D.Double(181, 168, 10, 43));
				g.setColor(Color.white);
				g.drawLine(187, 175, 187, 205);
				g.setColor(Color.blue);
				g2.fill(new Ellipse2D.Double(173.0, 185.0, 25.0, 10.0));
				break;
			case 9:
				// 1rst row left red 
				g.setColor(red);
				g2.fill(new Ellipse2D.Double(93.0, 78.0, 25.0, 10.0));
				g2.fill(new Ellipse2D.Double(93.0, 112.0, 25.0, 10.0));
				g2.fill(new Rectangle2D.Double(101, 80, 10, 40));
				g.setColor(Color.white);
				g.drawLine(107, 85, 107, 115);
				g.setColor(red);
				g2.fill(new Ellipse2D.Double(93.0, 95.0, 25.0, 10.0));
				
				// 1rst row left 2 blue 
				g.setColor(blue);
				g2.fill(new Ellipse2D.Double(133.0, 78.0, 25.0, 10.0));
				g2.fill(new Ellipse2D.Double(133.0, 112.0, 25.0, 10.0));
				g2.fill(new Rectangle2D.Double(141, 80, 10, 40));
				g.setColor(Color.white);
				g.drawLine(147, 85, 147, 115);
				g.setColor(blue);
				g2.fill(new Ellipse2D.Double(133.0, 95.0, 25.0, 10.0));
				
				// 1rst row left 3 green 
				g.setColor(green);
				g2.fill(new Ellipse2D.Double(173.0, 78.0, 25.0, 10.0));
				g2.fill(new Ellipse2D.Double(173.0, 112.0, 25.0, 10.0));
				g2.fill(new Rectangle2D.Double(181, 80, 10, 40));
				g.setColor(Color.white);
				g.drawLine(187, 85, 187, 115);
				g.setColor(green);
				g2.fill(new Ellipse2D.Double(173.0, 95.0, 25.0, 10.0));
				
				// 2nd row left red 
				g.setColor(red);
				g2.fill(new Ellipse2D.Double(93.0, 125.0, 25.0, 10.0));
				g2.fill(new Ellipse2D.Double(93.0, 159.0, 25.0, 10.0));
				g2.fill(new Rectangle2D.Double(101, 127, 10, 40));
				g.setColor(Color.white);
				g.drawLine(107, 132, 107, 165);
				g.setColor(red);
				g2.fill(new Ellipse2D.Double(93.0, 143.0, 25.0, 10.0));
				
				// 2nd row left 2 blue 
				g.setColor(blue);
				g2.fill(new Ellipse2D.Double(133.0, 125.0, 25.0, 10.0));
				g2.fill(new Ellipse2D.Double(133.0, 159.0, 25.0, 10.0));
				g2.fill(new Rectangle2D.Double(141, 127, 10, 40));
				g.setColor(Color.white);
				g.drawLine(147, 132, 147, 165);
				g.setColor(blue);
				g2.fill(new Ellipse2D.Double(133.0, 143.0, 25.0, 10.0));
				
				// 2nd row left 3 green 
				g.setColor(green);
				g2.fill(new Ellipse2D.Double(173.0, 125.0, 25.0, 10.0));
				g2.fill(new Ellipse2D.Double(173.0, 159.0, 25.0, 10.0));
				g2.fill(new Rectangle2D.Double(181, 127, 10, 40));
				g.setColor(Color.white);
				g.drawLine(187, 132, 187, 165);
				g.setColor(green);
				g2.fill(new Ellipse2D.Double(173.0, 143.0, 25.0, 10.0));
				
				// 3rd row left red 
				g.setColor(red);
				g2.fill(new Ellipse2D.Double(93.0, 170.0, 25.0, 10.0));
				g2.fill(new Ellipse2D.Double(93.0, 204.0, 25.0, 10.0));
				g2.fill(new Rectangle2D.Double(101, 172, 10, 40));
				g.setColor(Color.white);
				g.drawLine(107, 177, 107, 210);
				g.setColor(red);
				g2.fill(new Ellipse2D.Double(93.0, 188.0, 25.0, 10.0));
				
				// 3rd row left 2 blue 
				g.setColor(blue);
				g2.fill(new Ellipse2D.Double(133.0, 170.0, 25.0, 10.0));
				g2.fill(new Ellipse2D.Double(133.0, 204.0, 25.0, 10.0));
				g2.fill(new Rectangle2D.Double(141, 172, 10, 40));
				g.setColor(Color.white);
				g.drawLine(147, 177, 147, 210);
				g.setColor(blue);
				g2.fill(new Ellipse2D.Double(133.0, 188.0, 25.0, 10.0));
				
				// 3rd row left 3 green 
				g.setColor(green);
				g2.fill(new Ellipse2D.Double(173.0, 170.0, 25.0, 10.0));
				g2.fill(new Ellipse2D.Double(173.0, 204.0, 25.0, 10.0));
				g2.fill(new Rectangle2D.Double(181, 172, 10, 40));
				g.setColor(Color.white);
				g.drawLine(187, 177, 187, 210);
				g.setColor(green);
				g2.fill(new Ellipse2D.Double(173.0, 188.0, 25.0, 10.0));
				break;
			default: 
				    g.drawString("Invalid rank",150, 60);
					break;
		}
	 	
	}	
	
	public String toString()
	{
		switch(super.rank)
		{
			case 2:  return "Bamboo " + 2;
			case 3:  return "Bamboo " + 3;
			case 4:  return "Bamboo " + 4;
			case 5:  return "Bamboo " + 5;
			case 6:  return "Bamboo " + 6;
			case 7:  return "Bamboo " + 7;
			case 8:  return "Bamboo " + 8;
			case 9:  return "Bamboo " + 9;
			default: return "Invalid rank";
		}
	}
	public static void main(String[] args)
	{
		JFrame	frame = new JFrame();

		frame.setLayout(new FlowLayout());
		frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		frame.setTitle("Bamboo Tiles");

		frame.add(new BambooTile(2));
		frame.add(new BambooTile(3));
		frame.add(new BambooTile(4));
		frame.add(new BambooTile(5));
		frame.add(new BambooTile(6));
		frame.add(new BambooTile(7));
		frame.add(new BambooTile(8));
		frame.add(new BambooTile(9));

		frame.pack();
		frame.setVisible(true);
	}
}
