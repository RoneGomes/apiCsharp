import { TextInput, View ,Button} from "react-native";
import ClienteService from "../Services/ClienteService";

export default function Cadastro() {

    const [nome, setNome] = useState("");
    const [cpf, setCpf] = useState("");
    const [email, setEmail] = useState("");
    const [dataNacimento, setDataNascimento] = useState("");
    const [senha, setSenha] = useState("");
    const [clientes,setClientes] = useState([]);


    const getAllCliente = () => {
        ClienteService.getAllCliente()
            .then((response) => {
                setClientes(response.data);
            })
            .catch((error) => {
                console.log(error);
            });
    };

    useEffect(() => {
        getAllCliente();
    }, []);



    const criarCliente = (e) => {
        e.preventDefault();

        const cliente = {
            nome, cpf, email, dataNacimento,
            senha
        };

        ClienteService.createCliente(cliente)
            .then((response) => {
                navigate("/Voo")
                alert("cliente cadastrato com sucesso!")
            });

        return (

            <View>

                <TextInput
                    placeholder="usuraio"
                    id="usuario"
                    name="usuario"
                    size={40}
                    className="form-control"
                    value={nome}
                    onChange={(e) => setNome(e.target.value)}
                />
                <TextInput
                    placeholder="digite o email "
                    type="email"
                    id="email"
                    name="email"
                    size={15}
                    className="form-control"
                    value={email}
                    onChange={(e) => setEmail(e.target.value)}
                />

                <TextInput
                    placeholder="digite seu data de nascimento"
                    id="data"
                    name="data"
                    size={40}
                    className="form-control"

                    value={dataNacimento}
                    onChange={(e) => setDataNascimento(e.target.value)}
                />
                <TextInput
                    placeholder="digite cpf"
                    id="cpf"
                    name="cpf"
                    size={40}
                    className="form-control"
                    value={cpf}
                    onChange={(e) => setCpf(e.target.value)}
                />

                <TextInput
                    placeholder="digite senha"
                    id="senha"
                    name="senha"
                    size={40}
                    className="form-control"
                    value={cpf}
                    onChange={(e) => setSenha(e.target.value)}
                />

                        <Button
                        onPress={(e) => criarCliente(e)}
                        > cadastrar</Button>
            </View>
            

            
        )
    }
}