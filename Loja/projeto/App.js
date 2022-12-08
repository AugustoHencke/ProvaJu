// import { StatusBar } from 'expo-status-bar';
import React, {Component} from 'react';
import { StyleSheet, Text, View, TextInput, TouchableOpacity, FlatList } from 'react-native';

//Import dos arquivos
import Api from './src/services/api';
import Lojas from './src/Lojas';
import Estilos from './src/css/index';

class App extends Component{
  constructor(props){
    super(props);
    this.state = {
      lojas: []
    }
  }

  async componentDidMount(){
    const response = await Api.get('/');
    this.setState({
      lojas: response.data
    })
  }

  render(){
    return(
      <View style={Estilos.container}>
        <FlatList 
          data={this.state.lojas}
          keyExtractor={item => item.id.toString()}
          renderItem={ (item) => <Lojas data={item}/> }
        />
      <Text style={Estilos.textoTela}>Teste</Text>

      </View>
    );
  }
}

export default App;