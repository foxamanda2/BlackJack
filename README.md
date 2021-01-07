# PEDAC:BlackJack

## P=Problem

## Rules of game play

-Deck of 52 shuffled cards with a suit and face.
-Deal out 2 cards each. Two cards to the computer. Two cards to the player. Show the player cards, but hide the computers cards (dealer).
-Once the player gets their cards they should be able to choose to continue to HIT until they decide to STAND(stop) or they bust (over 21 cards)
-If hit is chosen they will be dealt another card as well as the computer(dealer)
-\*If the dealer hits 17 or more they automatically stand.
-If the computers(dealers) hand goes over 21 they automatically lose.

## Rules to be applied to game

-Aces are worth 11 points.
-Face cards ("jack","queen","King") are worth 10 points
-Ties go to the computer(dealer)
-There needs to be an option to play again.
-Winner should be displayed. Aka. the player that is closer to 21 without going over.

## E= Examples

-If a player is dealt a "6 of spades" and a "3 of clubs" they can decide to hit because their total only equals 9.
-If a player is dealt a "10 of hearts" and an "ace of diamonds" they can decide to stand because their hand equals 21.However, if the computers hits and they also equal 21 the computer automatically wins (look at rule with Ties)
-If the computer busts (over 21) and the player is less than 21 than the player wins.
-If the computer is dealt a "2 of Hearts" and a "5 of spades" the computer is automatically dealt another card until it equals 17 or more.

## D= Data Structure

-Class needed for deck of cards
--string List needed for face values and suit
--string List needed for the deck of cards
---Method needed to shuffle cards
---Method needed to int needed to implement values to the the cards
-Class needed for computers hand
--Two cards need to be dealt to the player
--Statement needs to be written
-Class needed for the players hand
--Two cards need to be dealt to the player
--Once player is dealt cards they can be revealed to player
---Player can decide to "Hit" or "Stand"
-----If player hits another card will be dealt.
-----If player stands reveal the computers cards.

-Method needed for game play

## A= Algorithm

I.Create a class to store the deck of cards
II.Inside the class add as string list for face card and suit
II. Create a combined string List for the Deck of cards
III.Create a method section to randomly shuffle the deck
IIII. Randomly shuffle the deck.
III.Create a method to assign a int(Ace=11 FaceValues=10) value to each card.

I. Create a class to store the players hand
II. Deal the player 2 cards off the top of the deck (from the altered deck)
II. Show the player their cards
II. Take those cards out of the deck
II. Ask the player to "Hit" or "Stand"
III. Create a method for "Hit" and "Stand"
IIII. If "Hit" Is selected add an additional card to the players hand. (Remove cards added)
IIII. If cards are over 21 it is a bust and the computer has won.
IIII. If "Stand" Is selected redirect to the computer(dealer) class to continue turn.
III. If it is a bust mark as lost.
III. If the player decides to stand save that value.

-Might explore the idea of one class in order to create the variables more at the end.

I. Create a class to store computers(dealer) hand
II. Deal the computer(dealer) 2 cards off the top of the deck, but do not reveal the cards just store them
II. Take those values out of the deck. (New variable?)
III. Method to "Hit" or "Stand"
IIII. Add card to dealers hand.
IIII. If the cards added are less than 17 add an additional card
IIII. If the card added are more than 17 stop adding cards
IIII. If the card is more than 21 keep data, but mark as busted.
IIII. Take any cards added out of the deck.
III. If if is busted mark as busted
III. Save value of final cards

I. Create two new variables and compare the values.
II If player value is greater than computer value player has won
II. If computer value is greater than player than computer has won
II. If player is busted computer wins
II. If computer busted player has won.
II. If it is a tie than the computer has won
