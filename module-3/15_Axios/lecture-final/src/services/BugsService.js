import Axios from 'axios'; // Grab axios from the installed node_modules

// Configuration options for Axios
let options = {
    baseURL: 'https://bugslist.azurewebsites.net/'
}

let client = Axios.create(options); // Creating the equivalent of a RestClient in RestSharp

export default {

    getAllBugs() { // Returns a promise
        return client.get('/bugs'); // Does a GET request to baseURL + /bugs
    },

    getBug(id) {
        return client.get('/bugs/' + id) // GET bugs/42
    },

    addBug(newBug) {
        // Equivalent of request.AddJsonBody
        return client.post('/bugs', newBug); // newBug is our request body
    },

    updateBug(bug) {
        return client.put('/bugs', bug); 
    },

    deleteBug(id) {
        return client.delete('/bugs/' + id);
    }

}