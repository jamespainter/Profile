import java.awt.Color;
import java.awt.Dimension;
import java.awt.FlowLayout;
import java.awt.GradientPaint;
import java.awt.Graphics;
import java.awt.Graphics2D;
import java.awt.geom.Ellipse2D;
import java.awt.geom.Rectangle2D;

import javax.swing.JFrame;

public class WhiteDragonTile extends Tile {
	public String toString()
	{
		return "White Dragon";
		
	}
	public void paintComponent(Graphics g)
	 {
		 super.paintComponent(g);
		 Graphics2D g2 = (Graphics2D)g;
		  
		 Color c = new Color(1.0f, 0.0f, 0.0f, 0.0f);
		 
		 g2.draw(new Rectangle2D.Double(75, 79, 140, 140));	
		 g2.draw(new Rectangle2D.Double(64, 69, 161, 161));
		 	//top
		   	g.setColor(Color.blue);
			g2.fill(new Rectangle2D.Double(65, 70, 20, 10));
			g.setColor(c);
			g2.fill(new Rectangle2D.Double(85, 70, 20, 10));
			g.setColor(Color.blue);
			g2.fill(new Rectangle2D.Double(105, 70, 20, 10));
			g.setColor(c);
			g2.fill(new Rectangle2D.Double(125, 70, 20, 10));
			g.setColor(Color.blue);
			g2.fill(new Rectangle2D.Double(145, 70, 20, 10));
			g.setColor(c);
			g2.fill(new Rectangle2D.Double(165, 70, 20, 10));
			g.setColor(Color.blue);
			g2.fill(new Rectangle2D.Double(185, 70, 20, 10));
			g.setColor(c);
			g2.fill(new Rectangle2D.Double(205, 70, 20, 10));
		 	//left Side
			g.setColor(c);
			g2.fill(new Rectangle2D.Double(65, 80, 10, 20));
			g.setColor(Color.blue);
			g2.fill(new Rectangle2D.Double(65, 100, 10, 20));
			g.setColor(c);
			g2.fill(new Rectangle2D.Double(65, 120, 10, 20));
			g.setColor(Color.blue);
			g2.fill(new Rectangle2D.Double(65, 140, 10, 20));
			g.setColor(c);
			g2.fill(new Rectangle2D.Double(65, 160, 10, 20));
			g.setColor(Color.blue);
			g2.fill(new Rectangle2D.Double(65, 180, 10, 20));
			g.setColor(c);
			g2.fill(new Rectangle2D.Double(65, 200, 10, 20));
			//bottom
			g.setColor(Color.blue);
			g2.fill(new Rectangle2D.Double(65, 220, 20, 10));
			g.setColor(c);
			g2.fill(new Rectangle2D.Double(85, 220, 20, 10));
			g.setColor(Color.blue);
			g2.fill(new Rectangle2D.Double(105, 220, 20, 10));
			g.setColor(c);
			g2.fill(new Rectangle2D.Double(125, 220, 20, 10));
			g.setColor(Color.blue);
			g2.fill(new Rectangle2D.Double(145, 220, 20, 10));
			g.setColor(c);
			g2.fill(new Rectangle2D.Double(165, 220, 20, 10));
			g.setColor(Color.blue);
			g2.fill(new Rectangle2D.Double(185, 220, 20, 10));
			g.setColor(c);
			g2.fill(new Rectangle2D.Double(205, 220, 20, 10));
			//right side
			g.setColor(Color.blue);
			g2.fill(new Rectangle2D.Double(215, 200, 10, 20));
			g.setColor(c);
			g2.fill(new Rectangle2D.Double(215, 180, 10, 20));
			g.setColor(Color.blue);
			g2.fill(new Rectangle2D.Double(215, 160, 10, 20));
			g.setColor(c);
			g2.fill(new Rectangle2D.Double(215, 140, 10, 20));
			g.setColor(Color.blue);
			g2.fill(new Rectangle2D.Double(215, 120, 10, 20));
			g.setColor(c);
			g2.fill(new Rectangle2D.Double(215, 100, 10, 20));
			g.setColor(Color.blue);
			g2.fill(new Rectangle2D.Double(215, 80, 10, 20));
	 }
	public static void main(String[] args)
	{
		JFrame	frame = new JFrame();

		frame.setLayout(new FlowLayout());
		frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		frame.setTitle("White Dragon Tile");

		frame.add(new WhiteDragonTile());

		frame.pack();
		frame.setVisible(true);
	}
}
