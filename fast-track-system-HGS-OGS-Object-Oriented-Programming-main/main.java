import javax.swing.Box;

// cars
interface MustPay {
    int odeme();
}

abstract class Car implements MustPay {
    int bakiye;
    int ucret;

    public int odeme() {
        bakiye -= ucret;
        return bakiye;
    }

    public int getBakiye() {
        return bakiye;
    }

    public int setBakiye(int bakiye) {
        this.bakiye = bakiye;
        return bakiye;
    }
}

class Auto extends Car {
    public Auto() {
        ucret = 3;
    }
}

class PanelVan extends Car {
    public PanelVan() {
        ucret = 5;
    }
}

class Truck extends Car {
    public Truck() {
        ucret = 10;
    }
}
// cars ended

// boxOffice
class BoxOffice {
    Car list[];
    int counter;

    BoxOffice() {
        list = new Car[20];
        counter = 0;
    }

    void pay(Car c) {
        list[counter++] = c;
        c.odeme();
    }
}
// boxOffice ended

//managment
class  Management {
   
    int iterateCarAndSumAllCarsMoney(BoxOffice boxOffice) {
        int sum = 0;
        for (int i = 0; i < boxOffice.counter; i++) {
               sum += boxOffice.list[i].getBakiye();
        }
        return sum;
    }

}
//managment ended

class Main {
    public static void main(String args[]) {
        BoxOffice boxOffice = new BoxOffice();
        Auto auto = new Auto();
        PanelVan panelVan = new PanelVan();
        Truck truck = new Truck();

        auto.setBakiye(100);
        panelVan.setBakiye(100);
        truck.setBakiye(100);

        boxOffice.pay(auto);
        boxOffice.pay(panelVan);
        boxOffice.pay(truck);

        // System.out.println(boxOffice.list[0].getBakiye());
        Management management = new Management();
        System.out.println(management.iterateCarAndSumAllCarsMoney(boxOffice));

    }
}
