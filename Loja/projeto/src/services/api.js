import axios from "axios";

const api = axios.create({
    baseURL: 'http://localhost:40713/loja'
});

export default api;