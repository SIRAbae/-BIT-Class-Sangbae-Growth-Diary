package example3;

import java.util.ArrayList;

/*
 * �޴�1 2��, �޴�2 1��, �޴�5 3��
 */
public class Order {
	private String menuname;
	private int count;

	public Order(String _menuname, int _count) {
		setMenuname(_menuname);
		setCount (_count);
		
	}
	
	public String getMenuname() {
		return menuname;
	}

	public void setMenuname(String menuname) {
		this.menuname = menuname;
	}
	
	public int getCount() {
		return count;
	}

	public void setCount(int count) {
		this.count = count;
	}
	
	public void Print() {
		System.out.println("�޴��� : " + menuname);
		System.out.println("�Ǹż��� : " + count);
	}
	
	@Override
	public String toString() {
		return String.format("%s\t %d��", menuname, count);
	}
	}//�ϳ��� �޴��� �󸶳� ���״���?


class OrderList{
	private int idx = 0;
	private ArrayList<Order> orderlist = new ArrayList<Order>();
	
	private static int S_COUNT = 1;
	
	public OrderList() {
		idx = S_COUNT++;
	}
	
	public int getIdx() {
		return idx;
	}
	
	public void Add (Order order) {
		orderlist.add(order);
	}
	
	public void Print() {
		System.out.println("========================================");
		System.out.println("�ֹ���ȣ : " + idx);
		System.out.println("========================================");
		for(Order od : orderlist) {
			System.out.println(" >> " + od);
		}
		System.out.println("========================================");
	}
}//�޴��� ��ŲȽ��