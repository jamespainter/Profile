import java.awt.*;
import java.awt.event.*;
import javax.swing.*;
import java.awt.font.*;

public class CircleTile extends RankTile{
	
	public CircleTile(int rank)
	{
		 
		super(rank);
		setToolTipText(toString());
	}
	public void paintComponent(Graphics g)
	{
	 	super.paintComponent(g);
	 	
	 	//g.drawOval(x, y, width, height);
	 	Color green = Color.decode("#00CD00");
	 	Graphics2D	g2 = (Graphics2D)g;
	 	
	 	switch(super.rank)
		{
			case 1: 
					
				    g.drawOval(90, 90, 125, 125);
				     
				    
				    g.setColor(green);
				    g2.fillOval(90, 90, 125, 125);
				    
				    g.setColor(Color.white);
				    g.drawOval(132, 130, 40, 40);
				    
				    g.setColor(Color.RED);
				    g2.fillOval(132, 130, 40, 40);
				    
				    g.setColor(Color.WHITE);
				    //x through middle
				    g.drawLine(143, 137, 167, 165);
				    g.drawLine(143, 164, 167, 135);
				    
				    //little white boxes
				    g.fillRect(140, 107, 5, 5);
				    g.fillRect(125, 113, 5, 5);
				    //g.fillRect(135, 109, 3, 3);
				    g.fillRect(109, 140, 5, 5);
				    g.fillRect(115, 125, 5, 5);
				    g.fillRect(109, 153, 5, 5);
				    g.fillRect(112, 167, 5, 5);
				    g.fillRect(119, 177, 5, 5);
				    g.fillRect(133, 185, 5, 5);
				    g.fillRect(147, 189, 5, 5);
				    g.fillRect(164, 187, 5, 5);
				    g.fillRect(178, 178, 5, 5);
				    g.fillRect(188, 165, 5, 5);
				    g.fillRect(191, 147, 5, 5);
				    g.fillRect(188, 130, 5, 5);
				    g.fillRect(176, 115, 5, 5);
				    g.fillRect(160, 108, 5, 5);
				break;
			case 2: 
			// top green dot
				g.setColor(Color.white);
			    g.drawOval(123, 100, 40, 40);
			    g.setColor(green);
			    g2.fillOval(123, 100, 40, 40);
			    g.setColor(Color.WHITE);
			    //x through middle
			    g.drawLine(133, 107, 155, 135);
			    g.drawLine(133, 134, 155, 105);
			    
			 //bottom red dot
				g.setColor(Color.white);
			    g.drawOval(123, 170, 40, 40);
			    g.setColor(Color.RED);
			    g2.fillOval(123, 170, 40, 40);
			    g.setColor(Color.WHITE);
			    //x through middle
			    g.drawLine(133, 177, 160, 205);
			    g.drawLine(133, 204, 160, 175);
				break;
			case 3: 
			// top blue dot
				g.setColor(Color.white);
			    g.drawOval(75, 70, 40, 40);
			    
			    g.setColor(Color.blue);
			    g2.fillOval(75, 70, 40, 40);
			    
			    g.setColor(Color.WHITE);
			    //x through middle
			    g.drawLine(85, 77, 107, 105);
			    g.drawLine(85, 104, 107, 75);
			    
			 
			// middle red dot
				g.setColor(Color.white);
			    g.drawOval(130, 130, 40, 40);
			    
			    g.setColor(Color.red);
			    g2.fillOval(130, 130, 40, 40);
			    
			    g.setColor(Color.WHITE);
			    //x through middle
			    g.drawLine(140, 137, 162, 165);
			    g.drawLine(140, 164, 162, 135);
			    
			    
			 // bottom green dot
				g.setColor(Color.white);
			    g.drawOval(190, 190, 40, 40);
			    
			    g.setColor(green);
			    g2.fillOval(190, 190, 40, 40);
			    
			    g.setColor(Color.WHITE);
			    //x through middle
			    g.drawLine(200, 197, 222, 225);
			    g.drawLine(200, 224, 222, 195);
			    break;
			case 4: 
			// top blue dot
				g.setColor(Color.white);
			    g.drawOval(103, 100, 40, 40);
			    g.setColor(Color.blue);
			    g2.fillOval(103, 100, 40, 40);
			    g.setColor(Color.WHITE);
			    //x through middle
			    g.drawLine(113, 107, 135, 135);
			    g.drawLine(113, 134, 135, 105);
			    
			 //bottom green dot
				g.setColor(Color.white);
			    g.drawOval(103, 170, 40, 40);
			    g.setColor(green);
			    g2.fillOval(103, 170, 40, 40);
			    g.setColor(Color.WHITE);
			    //x through middle
			    g.drawLine(113, 177, 140, 205);
			    g.drawLine(113, 204, 140, 175);
			 
			    
			 // Second Set top green dot
				g.setColor(Color.white);
			    g.drawOval(173, 100, 40, 40);
			    g.setColor(green);
			    g2.fillOval(173, 100, 40, 40);
			    g.setColor(Color.WHITE);
			    //x through middle
			    g.drawLine(183, 107, 205, 135);
			    g.drawLine(183, 134, 205, 105);
			    
			 // Second Set bottom blue dot
				g.setColor(Color.white);
			    g.drawOval(173, 170, 40, 40);
			    g.setColor(Color.blue);
			    g2.fillOval(173, 170, 40, 40);
			    g.setColor(Color.WHITE);
			    //x through middle
			    g.drawLine(183, 177, 210, 205);
			    g.drawLine(183, 204, 210, 175);
				break;
			case 5: 
				// top blue dot
				g.setColor(Color.white);
			    g.drawOval(75, 70, 40, 40);
			    
			    g.setColor(Color.blue);
			    g2.fillOval(75, 70, 40, 40);
			    
			    g.setColor(Color.WHITE);
			    //x through middle
			    g.drawLine(85, 77, 107, 105);
			    g.drawLine(85, 104, 107, 75);
			    
			 
			// middle red dot
				g.setColor(Color.white);
			    g.drawOval(130, 130, 40, 40);
			    
			    g.setColor(Color.red);
			    g2.fillOval(130, 130, 40, 40);
			    
			    g.setColor(Color.WHITE);
			    //x through middle
			    g.drawLine(140, 137, 162, 165);
			    g.drawLine(140, 164, 162, 135);
			    
			    
			 // bottom right corner blue dot
				g.setColor(Color.white);
			    g.drawOval(190, 190, 40, 40);
			    
			    g.setColor(Color.blue);
			    g2.fillOval(190, 190, 40, 40);
			    
			    g.setColor(Color.WHITE);
			    //x through middle
			    g.drawLine(200, 197, 222, 225);
			    g.drawLine(200, 224, 222, 195);
			    
			 // bottom left corner green dot
				g.setColor(Color.white);
			    g.drawOval(75, 190, 40, 40);
			    
			    g.setColor(green);
			    g2.fillOval(75, 190, 40, 40);
			    
			    g.setColor(Color.WHITE);
			    //x through middle
			    g.drawLine(85, 197, 107, 225);
			    g.drawLine(85, 224, 107, 195); 
			   
			 // top right corner green dot
				g.setColor(Color.white);
			    g.drawOval(185, 70, 40, 40);
			    
			    g.setColor(green);
			    g2.fillOval(185, 70, 40, 40);
			    
			    g.setColor(Color.WHITE);
			    //x through middle
			    g.drawLine(195, 77, 217, 105);
			    g.drawLine(195, 104, 217, 75);
				break;
			case 6:  
			// 1rst row right green dot
				g.setColor(Color.white);
			    g.drawOval(103, 70, 40, 40);
			    g.setColor(green);
			    g2.fillOval(173, 70, 40, 40);
			    g.setColor(Color.WHITE);
			    //x through middle
			    g.drawLine(183, 77, 205, 105);
			    g.drawLine(183, 104, 205, 75);

			// 1rst row left red dot
				g.setColor(Color.white);
			    g.drawOval(103, 70, 40, 40);
			    g.setColor(green);
			    g2.fillOval(103, 70, 40, 40);
			    g.setColor(Color.WHITE);
			    //x through middle
			    g.drawLine(113, 77, 135, 105);
			    g.drawLine(113, 104, 135, 75);
			    
			    
			// 2nd row left red dot
				g.setColor(Color.white);
			    g.drawOval(103, 130, 40, 40);
			    g.setColor(Color.RED);
			    g2.fillOval(103, 130, 40, 40);
			    g.setColor(Color.WHITE);
			    //x through middle
			    g.drawLine(113, 137, 135, 165);
			    g.drawLine(113, 164, 135, 135);
			 
			 // 2nd row right red dot
				g.setColor(Color.white);
			    g.drawOval(173, 130, 40, 40);
			    g.setColor(Color.RED);
			    g2.fillOval(173, 130, 40, 40);
			    g.setColor(Color.WHITE);
			    //x through middle
			    g.drawLine(183, 137, 205, 165);
			    g.drawLine(183, 164, 205, 135);
			 
			 // 3rd row left red dot
				g.setColor(Color.white);
			    g.drawOval(103, 190, 40, 40);
			    g.setColor(Color.RED);
			    g2.fillOval(103, 190, 40, 40);
			    g.setColor(Color.WHITE);
			    //x through middle
			    g.drawLine(113, 197, 140, 225);
			    g.drawLine(113, 224, 140, 195);
			 
			    
			 // 3rd row right red dot
				g.setColor(Color.white);
			    g.drawOval(173, 190, 40, 40);
			    g.setColor(Color.RED);
			    g2.fillOval(173, 190, 40, 40);
			    g.setColor(Color.WHITE);
			    //x through middle
			    g.drawLine(183, 197, 210, 225);
			    g.drawLine(183, 224, 210, 195);
				break;
			case 7: 
				// top green dot
				g.setColor(Color.white);
			    g.drawOval(75, 70, 40, 40);
			    
			    g.setColor(green);
			    g2.fillOval(75, 70, 40, 40);
			    
			    g.setColor(Color.WHITE);
			    //x through middle
			    g.drawLine(85, 77, 107, 105);
			    g.drawLine(85, 104, 107, 75);
			    
			 
			// middle green dot
				g.setColor(Color.white);
			    g.drawOval(130, 95, 40, 40);
			    
			    g.setColor(green);
			    g2.fillOval(130, 95, 40, 40);
			    
			    g.setColor(Color.WHITE);
			    //x through middle
			    g.drawLine(140, 103, 162, 130);
			    g.drawLine(140, 128, 162, 100);
			    
			    
			 // bottom green dot
				g.setColor(Color.white);
			    g.drawOval(190, 120, 40, 40);
			    
			    g.setColor(green);
			    g2.fillOval(190, 120, 40, 40);
			    
			    g.setColor(Color.WHITE);
			    //x through middle
			    g.drawLine(200, 127, 222, 155);
			    g.drawLine(200, 154, 222, 125);
			    
			 // top left red dot
				g.setColor(Color.white);
			    g.drawOval(83, 145, 40, 40);
			    g.setColor(Color.RED);
			    g2.fillOval(83, 145, 40, 40);
			    g.setColor(Color.WHITE);
			    //x through middle
			    g.drawLine(93, 152, 115, 180);
			    g.drawLine(93, 179, 115, 150);
			    
			 //bottom red dot
				g.setColor(Color.white);
			    g.drawOval(83, 190, 40, 40);
			    g.setColor(Color.RED);
			    g2.fillOval(83, 190, 40, 40);
			    g.setColor(Color.WHITE);
			    //x through middle
			    g.drawLine(93, 197, 120, 225);
			    g.drawLine(93, 224, 120, 195);
			 
			    
			 // Second top red dot
				g.setColor(Color.white);
			    g.drawOval(153, 145, 40, 40);
			    g.setColor(Color.RED);
			    g2.fillOval(153, 145, 40, 40);
			    g.setColor(Color.WHITE);
			    //x through middle
			    g.drawLine(163, 152, 190, 180);
			    g.drawLine(163, 179, 190, 150);
			    
			 // 2nd row bottom red dot
				g.setColor(Color.white);
			    g.drawOval(153, 190, 40, 40);
			    g.setColor(Color.RED);
			    g2.fillOval(153, 190, 40, 40);
			    g.setColor(Color.WHITE);
			    //x through middle
			    g.drawLine(163, 197, 190, 230);
			    g.drawLine(163, 224, 190, 195);
				break;
			case 8:
			// 1rst Row right blue dot
				g.setColor(Color.white);
			    g.drawOval(103, 52, 40, 40);
			    g.setColor(Color.blue);
			    g2.fillOval(173, 52, 40, 40);
			    g.setColor(Color.WHITE);
			    //x through middle
			    g.drawLine(183, 59, 205, 87);
			    g.drawLine(183, 86, 205, 57);

			// 1rst Row left blue dot
				g.setColor(Color.white);
			    g.drawOval(103, 52, 40, 40);
			    g.setColor(Color.blue);
			    g2.fillOval(103, 52, 40, 40);
			    g.setColor(Color.WHITE);
			    //x through middle
			    g.drawLine(113, 59, 135, 87);
			    g.drawLine(113, 86, 135, 57);
			    
			// 2nd Row right blue dot
				g.setColor(Color.white);
			    g.drawOval(103, 102, 40, 40);
			    g.setColor(Color.blue);
			    g2.fillOval(173, 102, 40, 40);
			    g.setColor(Color.WHITE);
			    //x through middle
			    g.drawLine(183, 109, 205, 137);
			    g.drawLine(183, 136, 205, 107);

			// 2nd Row left blue dot
				g.setColor(Color.white);
			    g.drawOval(103, 102, 40, 40);
			    g.setColor(Color.blue);
			    g2.fillOval(103, 102, 40, 40);
			    g.setColor(Color.WHITE);
			    //x through middle
			    g.drawLine(113, 109, 135, 137);
			    g.drawLine(113, 136, 135, 107);
			    
			    
			// 3rd row left blue dot
				g.setColor(Color.white);
			    g.drawOval(103, 155, 40, 40);
			    g.setColor(Color.blue);
			    g2.fillOval(103, 155, 40, 40);
			    g.setColor(Color.WHITE);
			    //x through middle
			    g.drawLine(113, 162, 135, 190);
			    g.drawLine(113, 189, 135, 160);
			    
			 // 3rd row right red dot
				g.setColor(Color.white);
			    g.drawOval(173, 155, 40, 40);
			    g.setColor(Color.blue);
			    g2.fillOval(173, 155, 40, 40);
			    g.setColor(Color.WHITE);
			    //x through middle
			    g.drawLine(183, 162, 205, 190);
			    g.drawLine(183, 189, 205, 160);
			    
			 //4th row left blue dot
				g.setColor(Color.white);
			    g.drawOval(103, 205, 40, 40);
			    g.setColor(Color.blue);
			    g2.fillOval(103, 205, 40, 40);
			    g.setColor(Color.WHITE);
			    //x through middle
			    g.drawLine(113, 212, 140, 240);
			    g.drawLine(113, 239, 140, 210);
			 
			    
			 // 4th row right blue dot
				g.setColor(Color.white);
			    g.drawOval(173, 205, 40, 40);
			    g.setColor(Color.blue);
			    g2.fillOval(173, 205, 40, 40);
			    g.setColor(Color.WHITE);
			    //x through middle
			    g.drawLine(183, 212, 210, 240);
			    g.drawLine(183, 239, 210, 210);
				break;
			case 9:
				// 1rst row right green dot
				g.setColor(Color.white);
			    g.drawOval(133, 70, 40, 40);
			    g.setColor(green);
			    g2.fillOval(133, 70, 40, 40);
			    g.setColor(Color.WHITE);
			    //x through middle
			    g.drawLine(143, 77, 165, 105);
			    g.drawLine(143, 104, 165, 75);

			// 1rst row left green dot
				g.setColor(Color.white);
			    g.drawOval(73, 70, 40, 40);
			    g.setColor(green);
			    g2.fillOval(73, 70, 40, 40);
			    g.setColor(Color.WHITE);
			    //x through middle
			    g.drawLine(83, 77, 105, 105);
			    g.drawLine(83, 104, 105, 75);
			    
			    
			// 2nd row left red dot
				g.setColor(Color.white);
			    g.drawOval(73, 130, 40, 40);
			    g.setColor(Color.RED);
			    g2.fillOval(73, 130, 40, 40);
			    g.setColor(Color.WHITE);
			    //x through middle
			    g.drawLine(83, 137, 105, 165);
			    g.drawLine(83, 164, 105, 135);
			 
			 // 2nd row right red dot
				g.setColor(Color.white);
			    g.drawOval(133, 130, 40, 40);
			    g.setColor(Color.RED);
			    g2.fillOval(133, 130, 40, 40);
			    g.setColor(Color.WHITE);
			    //x through middle
			    g.drawLine(143, 137, 165, 165);
			    g.drawLine(143, 164, 165, 135);
			 
			 // 3rd row left blue dot
				g.setColor(Color.white);
			    g.drawOval(73, 190, 40, 40);
			    g.setColor(Color.blue);
			    g2.fillOval(73, 190, 40, 40);
			    g.setColor(Color.WHITE);
			    //x through middle
			    g.drawLine(83, 197, 105, 225);
			    g.drawLine(83, 224, 105, 195);
			 
			    
			 // 3rd row right blue dot
				g.setColor(Color.white);
			    g.drawOval(133, 190, 40, 40);
			    g.setColor(Color.blue);
			    g2.fillOval(133, 190, 40, 40);
			    g.setColor(Color.WHITE);
			    //x through middle
			    g.drawLine(143, 197, 165, 225);
			    g.drawLine(143, 224, 165, 195);
			    
			    
			 // 1rst row right corner green dot
				g.setColor(Color.white);
			    g.drawOval(193, 70, 40, 40);
			    g.setColor(green);
			    g2.fillOval(193, 70, 40, 40);
			    g.setColor(Color.WHITE);
			    //x through middle
			    g.drawLine(203, 77, 225, 105);
			    g.drawLine(203, 104, 225, 75);
			    
			    
			 // 2nd row right middle red dot
				g.setColor(Color.white);
			    g.drawOval(193, 130, 40, 40);
			    g.setColor(Color.RED);
			    g2.fillOval(193, 130, 40, 40);
			    g.setColor(Color.WHITE);
			    //x through middle
			    g.drawLine(203, 137, 225, 165);
			    g.drawLine(203, 164, 225, 135);
			    
			 // 3rd row right bottom blue dot
				g.setColor(Color.white);
			    g.drawOval(193, 190, 40, 40);
			    g.setColor(Color.blue);
			    g2.fillOval(193, 190, 40, 40);
			    g.setColor(Color.WHITE);
			    //x through middle
			    g.drawLine(203, 197, 225, 225);
			    g.drawLine(203, 224, 225, 195);
			    
			    
				break;

			default: g.drawString("Invalid rank",150, 60);
		
		}
	}
	public String toString()
	{
		switch(super.rank)
		{
			case 1:  return "Circle " + 1;
			case 2:  return "Circle " + 2;
			case 3:  return "Circle " + 3;
			case 4:  return "Circle " + 4;
			case 5:  return "Circle " + 5;
			case 6:  return "Circle " + 6;
			case 7:  return "Circle " + 7;
			case 8:  return "Circle " + 8;
			case 9:  return "Circle " + 9;
			default: return "Invalid rank";
		
		}
		
	}
	
	public static void main(String[] args)
	{
		JFrame	frame = new JFrame();

		frame.setLayout(new FlowLayout());
		frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		frame.setTitle("Circle Tiles");

		frame.add(new CircleTile(1));
		frame.add(new CircleTile(2));
		frame.add(new CircleTile(3));
		frame.add(new CircleTile(4));
		frame.add(new CircleTile(5));
		frame.add(new CircleTile(6));
		frame.add(new CircleTile(7));
		frame.add(new CircleTile(8));
		frame.add(new CircleTile(9));

		frame.pack();
		frame.setVisible(true);
	}
}
