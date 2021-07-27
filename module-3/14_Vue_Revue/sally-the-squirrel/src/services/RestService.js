import axios from 'axios';

const http = axios.create({
  baseURL: "https://sallythesquirrelservice.azurewebsites.net"
});


const restService = {

    currentJWT: 'ThisIsAFakeJWT', // TODO: We could set this from a response if we wanted

    buildConfig() {
      return {
        headers: {'Access-Control-Allow-Origin': '*',
        'Access-Control-Allow-Methods': 'GET,PUT,POST,DELETE',
        'Access-Control-Allow-Headers': 'Content-Type',
        Authorization: "Bearer " + this.currentJWT
        }
      }
    },

    list() {
      return http.get('/questions', this.buildConfig());
    },
  
    get(id) {
      return http.get(`/questions/${id}`, this.buildConfig());
    },
  
    update(question) {
      return http.put(`/questions/${question.id}`, question, this.buildConfig());
    },

    create(question) {
      return http.post('/questions', question, this.buildConfig());
    },
  
    delete(question) {
      return http.delete(`/questions/${question.id}`, this.buildConfig());
    },

  };

export default restService;