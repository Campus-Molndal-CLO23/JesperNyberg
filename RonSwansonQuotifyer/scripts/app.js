'u0se strict';

window.addEventListener('load', () => {

    document.querySelector('#quoteButton').addEventListener('click', getQuote);

});

function getQuote() {

    fetch('http://ron-swanson-quotes.herokuapp.com/v2/quotes')
    .then(function(response) {
        if (response.status === 200) {
        return response.json();
    } else {
        throw new Error('Något gick fel vid hämtning av data.');
    }
    })
    .then(function(data) {
        presentQuote(data);
    })
    .catch(function(error) { 
        console.error('Fel:', error);
    });

}

function presentQuote(quote) {
    const blockQuote = document.querySelector('.section__quote');

    blockQuote.textContent = quote;
}