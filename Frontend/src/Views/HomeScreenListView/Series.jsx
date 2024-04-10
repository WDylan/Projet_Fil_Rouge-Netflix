// import React, { Component } from "react";
// import {
//     getSeriesApi,
//     searchSeriesApi,
//     postSeriesApi,
//     updateSeriesApi,
//     deleteSeriesApi,
// } from '../../ApiService';
// import "./Series.scss"
// import { variables } from "../../config/Variables";

// export class Series extends Component {

//     constructor(props) {
//         super(props);

//         this.state = {
//             films: []
//         }
//     }

//     refreshList() {
//         fetch(variables._BASE_URL + 'series')
//             .then(response => response.json())
//             .then(data => {
//                 this.setState({ series: data });
//             })
//     }

//     componentDidMount() {
//         this.refreshList();
//     }


//     render() {
//         const {
//             series 
//         }=this.state;
//         return (
//             <div>
//                 <table>
//                     <thead>
//                         <tr>
//                             <th>
//                                 IdFilm
//                             </th>
//                             <th>
//                                 Titre
//                             </th>
//                         </tr>
//                     </thead>
//                     <tbody>
//                         {Series.map(ser =>
//                             <tr key={ser.IdSerie}>
//                                 <td>{ser.IdSerie}</td>
//                                 <td>{ser.Titre}</td>
//                             </tr>)}
//                     </tbody>
//                 </table>
//             </div>
//         )
//     }
// }