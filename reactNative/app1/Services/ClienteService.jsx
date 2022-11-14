import axios from "axios";

const CLIENTE_API_URL = "http://localhost:8080/cliente";

class ClienteService {
  getAllCliente() {
    return axios.get(CLIENTE_API_URL);
  }

  createCliente(cliente) {
    return axios.post(CLIENTE_API_URL,cliente);
  }

  getPassagemById(clienteId) {
    return axios.get(CLIENTE_API_URL + "/" + clienteId);
  }

  updateCliente(cliente) {
    return axios.put(CLIENTE_API_URL + "/" + cliente);
  }

  deleteCliente(clienteId) {
    return axios.delete(CLIENTE_API_URL + "/" + clienteId);
  }
}

export default new ClienteService();