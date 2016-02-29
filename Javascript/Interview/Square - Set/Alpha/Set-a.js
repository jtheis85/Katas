// 1) Produce a deck with all possible cards
//
// 3 symbols, 3 numbers, 3 colors, 3 fills

var symbols = ['squiggle', 'oval', 'rectangle'];
var numbers = ['1','2','3'];
var colors  = ['red', 'green', 'blue'];
var fills   = ['open', 'solid', 'striped'];

var createDeck = function () {

    var deck = [];

    for(var s = 0; s < symbols.length; s++) {
        for(var n = 0; n < numbers.length; n++) {
            for(var c = 0; c < colors.length; c++) {
                for(var f = 0; f < fills.length; f++) {
                    deck.push({
                        symbol: symbols[s],
                        number: numbers[n],
                        color:  colors[c],
                        fill:   fills[f]
                    });
                }
            }
        }
    }
    return deck;
};

// 2) Draw a hand of 12 random cards
var drawHand = function (deck) {
    var hand = [];

    for(var i = 0; i < 12; i++) {
        //pick a card
        var index = getRandom(deck.length);
        hand.push(deck[index]);
        //remove the card from the deck
        deck.splice(index,1);
    }

    return hand;
};

var getRandom = function (num) {
    return Math.floor(
        Math.random() * num
    );
};

// 3) Determine all sets within the hand

function isSet(card1, card2, card3) {
    // 3 cards are a set if for each property, the cards all have the same value, OR
    // for each property, the cards all have a different vale

    // TODO: Clean this up!
    // Should be able to loop through the properties of a card somehow
    var sameSymbol         = card1.symbol === card2.symbol && card1.symbol === card3.symbol;
    var allDifferentSymbol = card1.symbol !== card2.symbol && card1.symbol !== card2.symbol && card2.symbol != card3.symbol;
    var sameNumber         = card1.number === card2.number && card1.number === card3.number;
    var allDifferentNumber = card1.number !== card2.number && card1.number !== card2.number && card2.number != card3.number;
    var sameColor          = card1.color === card2.color && card1.color === card3.color;
    var allDifferentColor  = card1.color !== card2.color && card1.color !== card2.color && card2.color != card3.color;
    var sameFill           = card1.fill === card2.fill && card1.fill === card3.fill;
    var allDifferentFill   = card1.fill !== card2.fill && card1.fill !== card2.fill && card2.fill != card3.fill;

    return (sameSymbol || allDifferentSymbol) && (sameNumber || allDifferentNumber) && (sameColor || allDifferentColor) &&
           (sameFill || allDifferentFill);
}

function getSets(cards) {
    // Degenerate case, not enough cards left to make any sets
    if(cards.length < 3)
        return [];
    // Base case, enough cards left for exactly one set
    if(cards.length === 3 && isSet(cards[0], cards[1], cards[2]))
        return [cards[0], cards[1], cards[2]];

    // How many candidate sets are there to consider?
    // In a normal hand, 12 choose 3 (order doesn't matter)
    // What's an efficient algorithm for checking all the combinations without duplicates?


    var sets = [];
    // Check the first card against the rest
    for(var c = 1; c < cards.length-1; c++) {
        if(isSet(cards[0], cards[c], cards[c+1]))
            sets.push([cards[0], cards[c], cards[c+1]]);
    }
    // Remove the first card (to prevent duplicated sets) and then test the remaining cards in the same way
    return sets.concat(getSets(cards.splice(1)));
}

// 4) Use a shuffle function

// 6) Determine the optimal usage of the hand (to score the most sets without reusing a card)

// 7) How to create a deck for an arbitrary number of properties with an arbitrary number of values (which may not be
//    the same number per property)?

var test1 = function () {
    var deck = createDeck();
    //console.log(deck);

    // (3 choose 1) ^ 4
    if(deck.length === 81) console.log("Test 1 Passed");
    else                   console.log("Test 1 Failed");
};

var test2 = function () {
    var hand = drawHand(createDeck());
    //console.log(hand);

    if(hand.length === 12) console.log("Test 2 Passed");
    else                   console.log("Test 2 Failed");
};

// Testing the first 3 cards of the deck
var test3 = function() {
    var deck = createDeck();
    //console.log(deck[0], deck[1], deck[3]);

    if(isSet(deck[0], deck[1], deck[2])) console.log("Test 3 Passed");
    else                                 console.log("Test 3 Failed");

};

// Testing the first 3 cards except the first
var test4 = function() {
    var deck = createDeck();
    //console.log(deck[1], deck[2], deck[3]);

    if(!isSet(deck[1], deck[2], deck[3])) console.log("Test 4 Passed");
    else                                  console.log("Test 4 Failed");

};

// Testing 3 custom cards, should be a set
var test5 = function() {
    var deck = [
        { symbol: symbols[0], number: numbers[1], color: colors[2], fill: fills[0] },
        { symbol: symbols[0], number: numbers[1], color: colors[2], fill: fills[1] },
        { symbol: symbols[0], number: numbers[1], color: colors[2], fill: fills[2] }
    ];

    if(isSet(deck[0], deck[1], deck[2])) console.log("Test 5 Passed");
    else                                 console.log("Test 5 Failed");

};

// Testing 3 custom cards, should be a set too
var test6 = function() {
    var deck = [
        { symbol: symbols[0], number: numbers[0], color: colors[0], fill: fills[0] },
        { symbol: symbols[1], number: numbers[1], color: colors[1], fill: fills[1] },
        { symbol: symbols[2], number: numbers[2], color: colors[2], fill: fills[2] }
    ];

    if(isSet(deck[0], deck[1], deck[2])) console.log("Test 6 Passed");
    else                                 console.log("Test 6 Failed");

};


// Testing 3 custom cards, should not be a set
var test7 = function() {
    var deck = [
        { symbol: symbols[0], number: numbers[0], color: colors[1], fill: fills[1] },
        { symbol: symbols[2], number: numbers[1], color: colors[1], fill: fills[1] },
        { symbol: symbols[2], number: numbers[0], color: colors[2], fill: fills[1] }
    ];

    if(!isSet(deck[0], deck[1], deck[2])) console.log("Test 7 Passed");
    else                                  console.log("Test 7 Failed");

};

// Testing a random hand for sets
var test8 = function () {
    var sets = getSets(drawHand(createDeck()));

    sets.forEach(function(set) {
       console.log(cardString(set[0]) + cardString(set[1]) + cardString(set[2]));
    });
};

function cardString(card) {
    return card.symbol + '-' + card.number + '-' + card.color + '-' + card.fill + '\n';
}

test1();
test2();
test3();
test4();
test5();
test6();
test7();
test8();