import { NavigationContainer } from "@react-navigation/native";

import { createStackNavigator } from "@react-navigation/stack";

import Voo from "../pages/Voo";
import Cadastro from "../pages/Cadastro";

const Stack = createStackNavigator();

function Routes(){

    return(
        <NavigationContainer>
            <Stack.Navigator>
                <Stack.Screen name=" Voo" component={Voo}/>
                <Stack.Screen name=" Cadastro" component={Cadastro}/>
            </Stack.Navigator>
        </NavigationContainer>

    );
}

export default Routes;