
/**
 * Aggiungi qui una descrizione della classe Main
 * 
 * @author (il tuo nome) 
 * @version (un numero di versione o una data)
 */
public class Main
{
    // variabili d'istanza - sostituisci l'esempio che segue con il tuo

    /**
     * Costruttore degli oggetti di classe  Main
     */

    /**
     * Un esempio di metodo - aggiungi i tuoi commenti
     * 
     * @param  y   un parametro d'esempio per un metodo
     * @return     la somma di x e y
     */
    public static void  main()
    {
        // metti qui il tuo codice
         Ricetta ricetta1= new Ricetta(30,"Pizza");
         System.out.println(ricetta1.toString());
         String ing[]={"Uova",};
         
         Ricetta r= new Ricetta(5,3,3,ing);
    }
}
