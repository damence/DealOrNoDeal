
#Se ili neshto

Windows Forms Application од Теодор Никола Младеновски и Дамјан Јовановски

1.Опис на апликацијата
- Апликацијата е верзија на популарниот македонски тв-квиз Се или нешто 

2.Упатство за употреба
- При стартување на апликацијата се отвара прозорец со 2 можни опции. Да се започне нова игра, или да се прикажат правилата на квизот

- Доколку се започне нова игра, се отвара прозорец со 16 кутии и сумите кои се кријат во секоја кутија. Со притискање (односно отварање)
на дадена кутија, сумата која се наоѓа во неа исчезнува. По секое отварање на одреден број на кутии, се отвара нов прозорец каде што 
"банкарот" дава понуда базирана на апроксимација на преостанатите суми и состојбата на тековната игра. Доколку играчот ја прифати понудата,
играта завршува и може да започне нова, во спротивно играта продолжува.

3.Податочни структури

Главните податочни структури се чуваат во класата  Game

public class Game
   
{      
public Game()
     
	//se chuvaat lista so kutii , promenliva za krugot , Random promenliva		   
        
public int getTurn()
        
	// the current turn
public int OpenBox()

	// deletes the clicked box from the list
public int calculateOffer()
	//calculate the average amount of money left in the boxes
	//divide the average with the number of boxes
	//multiply by the number of turns
	//divide by 20  
} 