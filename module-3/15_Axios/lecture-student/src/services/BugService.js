import Axios from 'axios';  //Grab axios from the installed node_modules

// Configuration options for Axios
let options = {
    baseURL: 'https://bugslist.azurewebsites.net'
}

let client = Axios.create(options); //create the equivalent of a RestClient in RestSharp

export default {
    getAllBugs(){
        return client.get('/bugs'); // Does a GET request to baseURL + /bugs
    }
}